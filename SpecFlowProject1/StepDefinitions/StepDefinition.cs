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

        [When("Set UserName value (.*)")]
        public void SetUserName(string vlaue)
        {
            LoginPage.SendUserName(vlaue);
        }

        [When("Set Pass value (.*)")]
        public void SetPass(string vlaue)
        {
            LoginPage.SendPassword(vlaue);
        }

        [When("Click Login button")]
        public void ClickLoginButton()
        {
            LoginPage.LoginButonClick();
        }

        [Then("Check url")]
        public void CheckUrl()
        {
            var result = Driver.GetDriver().Url;
            Assert.IsTrue(result == "https://www.saucedemo.com/inventory.html");
        }


        [When("Input hotel name (.*)")]
        public void inputHotelName(string hotelName)
        {
            BookingPage.InputHotelName(hotelName);
        }

        [When("Skip the pop-up window")]
        public void SkipWindow()
        {
            BookingPage.ClosePopUpWindow();
        }

        [Then("Check rating. Expected is (.*)")]
        public void Chechrating(string rating)
        {
            BookingPage.GetRatingByHotel();
            Assert.That(BookingPage.GetRatingByHotel(), Is.EqualTo(rating));
        }
    }
}
