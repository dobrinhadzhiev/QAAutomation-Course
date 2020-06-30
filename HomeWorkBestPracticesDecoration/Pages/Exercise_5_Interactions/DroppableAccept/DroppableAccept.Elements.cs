using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.DroppableAccept
{
    public partial class DroppableAccept
    {
        public WebElement NotAcceptabledraggableBox => Driver.FindElement(By.Id("notAcceptable"));

        public WebElement DroppableBox => Driver.FindElement(By.XPath("//div[@class='accept-drop-container']/div[@id='droppable']"));

    }
}
