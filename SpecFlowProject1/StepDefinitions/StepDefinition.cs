using NUnit.Framework;
using PageObjectLib.Factories;
using SpecFlowProject1.Pages;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class StepDefinition
    {
        [Given("Open Page (.*)")]
        public void OpenPage(string url)
        {
            Driver.GoUrl(url);
        }

        [When("Input hotel name (.*)")]
        public void InputHotelName(string hotelName)
        {
            BookingPage.InputHotelName(hotelName);
        }

        [When("Search the hotel")]
        public void SearchHotel()
        {
            BookingPage.SearchHotel();
        }

        [When("Skip the pop-up window")]
        public void SkipWindow()
        {
            BookingPage.ClosePopUpWindow();
        }

        [Then("Check rating. Expected is (.*)")]
        public void Chechrating(string expected)
        {
            var result = BookingPage.GetRatingByHotel().Remove(1);

            Assert.That(result, Is.EqualTo(expected.Remove(1)));
        }
    }
}
