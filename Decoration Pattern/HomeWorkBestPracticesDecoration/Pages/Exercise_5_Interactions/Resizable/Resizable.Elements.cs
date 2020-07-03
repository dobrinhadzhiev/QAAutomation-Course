using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.Resizable
{
    public partial class Resizable
    {
       public WebElement UpperBox => Driver.FindElement(By.Id("resizableBoxWithRestriction"));

       public WebElement ResizableHandleUpperBox => Driver.FindElement(By.XPath("//*[@id='resizableBoxWithRestriction']/span"));

    }
}
