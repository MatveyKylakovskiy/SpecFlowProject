using OpenQA.Selenium;
using PageObjectLib.Elements;
using PageObjectLib.Factories;

namespace SpecFlowProject1.Pages
{
    internal class BookingPage
    {
        private static string _url = "https://www.booking.com/searchresults.en-gb.html";

        private static WebElements _searchField = new(By.XPath("//input[@class='ada65db9b5']"));
        private static WebElements _ratingIcon =new(By.XPath("//div[@data-testid='review-score']//div//div[1]"));
        private static WebElements _popUpWindiwCloseButton = new(By.XPath("//*[contains(@class, 'bf33709ee1 a190bb5f27 dc0e35d124')]"));
        private static WebElements SelectHotelButton(string hotelName) => new(By.XPath($"//*[contains(text(),'{hotelName}')]"));


        public static void GoUrl()
        {
            Driver.GoUrl(_url);
        }
        public static void InputHotelName(string hotelName)
        {
            _searchField.Click();
            _searchField.SendValue(hotelName);
            SelectHotelButton(hotelName).Click();
        }

        public static void SearchHotel()
        {
            _searchField.SendValue(Keys.Enter);
        }

        public static string GetRatingByHotel()
        {
            return _ratingIcon.GetText().Substring(7);
        }

        public static void ClosePopUpWindow()
        {
            try
            {
                _popUpWindiwCloseButton.Click();
            }

            catch (Exception ex)
            {
            }
        }
    }
}
