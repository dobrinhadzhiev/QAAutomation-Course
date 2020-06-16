using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.Resizable
{
    public partial class Resizable
    {
       public IWebElement UpperBox => Driver.FindElement(By.Id("resizableBoxWithRestriction"));

       public IWebElement ResizableHandleUpperBox => Driver.FindElement(By.XPath("//*[@id='resizableBoxWithRestriction']/span"));

    }
}
