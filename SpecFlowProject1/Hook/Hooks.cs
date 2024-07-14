using PageObjectLib.Factories;

namespace SpecFlowProject1.Hook
{
    [Binding]
    internal class Hooks
    {
        [AfterScenario("CloseBrowser")]
        public void CloseBrowser()
        {
            Driver.QuitDriver();
        }
    }
}
