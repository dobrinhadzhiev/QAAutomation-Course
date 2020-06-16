using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.DroppableAccept
{
    public partial class DroppableAccept
    {
        public IWebElement NotAcceptabledraggableBox => Driver.FindElement(By.Id("notAcceptable"));

        public IWebElement DroppableBox => Driver.FindElement(By.XPath("//div[@class='accept-drop-container']/div[@id='droppable']"));

    }
}
