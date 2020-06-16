using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.SortableGrid
{
    public partial class SortableGrid
    {

       public IWebElement SortableGridButton => Driver.FindElement(By.Id("demo-tab-grid"));

        public IWebElement ButtonNum(int number) => Driver.FindElement(By.XPath($"//div[@class='create-grid']/child::div[{number}]"));


        public IWebElement Button(string number) => Driver.FindElement(By.XPath($"//div[@class='create-grid']/div[normalize-space(text())='{number}']"));


    }
}
