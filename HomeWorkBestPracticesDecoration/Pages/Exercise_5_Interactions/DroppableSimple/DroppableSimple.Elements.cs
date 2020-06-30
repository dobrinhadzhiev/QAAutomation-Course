using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.DroppableSimple
{
    public partial class DroppableSimple
    {        
        public WebElement DraggableBox => Driver.FindElement(By.Id("draggable"));

        public WebElement DroppableBox => Driver.FindElement(By.Id("droppable"));

        public WebElement DroppableAcceptTab => Driver.FindElement(By.Id("droppableExample-tab-accept"));
        
        public WebElement DroppableBoxText => Driver.FindElement(By.XPath("//*[@id='droppable']/p"));

    }
}
