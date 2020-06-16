using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.Draggable
{
    public partial class Draggable
    {
        public IWebElement DraggableBox => Driver.FindElement(By.Id("dragBox"));
    }
}
