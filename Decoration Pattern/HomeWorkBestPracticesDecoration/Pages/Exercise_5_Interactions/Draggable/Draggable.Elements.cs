using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.Draggable
{
    public partial class Draggable
    {
        public WebElement DraggableBox => Driver.FindElement(By.Id("dragBox"));
    }
}
