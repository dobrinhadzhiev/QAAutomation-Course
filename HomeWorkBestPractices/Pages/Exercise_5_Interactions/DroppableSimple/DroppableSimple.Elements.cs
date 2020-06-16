using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.DroppableSimple
{
    public partial class DroppableSimple
    {        
        public IWebElement DraggableBox => Driver.FindElement(By.Id("draggable"));

        public IWebElement DroppableBox => Driver.FindElement(By.Id("droppable"));

        public IWebElement DroppableAcceptTab => Driver.FindElement(By.Id("droppableExample-tab-accept"));
        
        public IWebElement DroppableBoxText => Driver.FindElement(By.XPath("//*[@id='droppable']/p"));

    }
}
