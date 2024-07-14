
using OpenQA.Selenium;
using PageObjectLib.Elements;
using PageObjectLib.Factories;

namespace SpecFlowProject1.Pages
{
    public class LoginPage
    {
        private const string _url = "https://www.saucedemo.com";
        public readonly static string _password = "secret_sauce";
        public readonly static Dictionary<string, string> LoginCredentials = new()
        {
            {"standard", "standard_user"},
            {"locked", "locked_out_user"},
            {"problem", "problem_user"},
            {"performance", "performance_glitch_user"},
            {"error", "error_user"},
            {"visual", "visual_user"}
        };

        private static WebElements UserNameInput() => new(By.Id("user-name"));
        private static WebElements PasswordInput() => new(By.Name("password"));
        private static WebElements LoginButton() => new(By.XPath("//input[@id='login-button']"));
        private static WebElements ErrorMessage() => new(By.CssSelector("h3[data-test='error']"));

        public static void GoToUrl(string url)
        {
            Driver.GoUrl(url);
        }
        public static void Login(string login, string password)
        {
            UserNameInput().SendValue(login);
            PasswordInput().SendValue(password);
            LoginButton().Click();
        }

        public static void SendUserName(string name) => UserNameInput().SendValue(name);
        public static void SendPassword(string pass) => PasswordInput().SendValue(pass);
        public static void LoginButonClick() => LoginButton().Click();
        public static string GetMessage() => ErrorMessage().GetText();

        public static WebElements GetElementsByName(string itemName)
        {
           return new WebElements(By.Name(itemName));
        }
    }
}
