using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.SelectableGrid
{
    public partial class SelectableGrid
    {

       public IWebElement SelectableGridButton => Driver.FindElement(By.Id("demo-tab-grid"));

        public IWebElement Button(string number) => Driver.FindElement(By.XPath($"//div[@id='gridContainer']//li[normalize-space(text())='{number}']"));

    }
}
