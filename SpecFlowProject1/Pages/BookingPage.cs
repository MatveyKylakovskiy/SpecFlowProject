using OpenQA.Selenium;
using PageObjectLib.Elements;
using PageObjectLib.Factories;

namespace SpecFlowProject1.Pages
{
    internal class BookingPage
    {
        private static string _url = "https://www.booking.com/searchresults.en-gb.html";
        private static WebElements SearchField = new(By.XPath("//input[@class='ada65db9b5']"));
        private static WebElements RatingIcon =new(By.XPath("//div[@data-testid='review-score']//div//div[1]"));
        private static WebElements PopUpWindiwCloseButton = new(By.XPath("//*[contains(@class, 'bf33709ee1 a190bb5f27 dc0e35d124')]"));
        private static WebElements SelectHotelButton(string hotelName) => new(By.XPath($"//*[contains(text(),'{hotelName}')]"));


        public static void GoUrl()
        {
            Driver.GoUrl(_url);
        }
        public static void InputHotelName(string hotelName)
        {
            SearchField.Click();
            SearchField.SendValue(hotelName);
            SelectHotelButton(hotelName).Click();
        }

        public static void SearchHotel()
        {
            SearchField.SendValue(Keys.Enter);
        }

        public static string GetRatingByHotel()
        {
            return RatingIcon.GetText().Substring(7);
        }

        public static void ClosePopUpWindow()
        {
            try
            {
                PopUpWindiwCloseButton.Click();
            }

            catch (Exception ex)
            {
            }
        }
    }
}
