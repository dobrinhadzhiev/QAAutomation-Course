using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.SortableGrid
{
    public partial class SortableGrid
    {

       public WebElement SortableGridButton => Driver.FindElement(By.Id("demo-tab-grid"));

        public WebElement ButtonNum(int number) => Driver.FindElement(By.XPath($"//div[@class='create-grid']/child::div[{number}]"));


        public WebElement Button(string number) => Driver.FindElement(By.XPath($"//div[@class='create-grid']/div[normalize-space(text())='{number}']"));


    }
}
