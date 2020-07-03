using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.SelectableGrid
{
    public partial class SelectableGrid
    {

       public WebElement SelectableGridButton => Driver.FindElement(By.Id("demo-tab-grid"));

        public WebElement Button(string number) => Driver.FindElement(By.XPath($"//div[@id='gridContainer']//li[normalize-space(text())='{number}']"));

    }
}
