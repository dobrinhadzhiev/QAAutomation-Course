using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.DroppableSimple
{
    public partial class DroppableSimple : BasePage
    {
        public DroppableSimple(WebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/droppable";


        public void MoveElementUntilColorChanges()
        {
            var moveElemenent = Builder
                                      .ClickAndHold(DraggableBox.WrappedElement)
                                      .MoveByOffset(20, 0);

            //While the color of the drop. box is different from blue , the element is moved by 20 pixels
            while (DroppableBox.GetCssValue("background-color") != "rgba(70, 130, 180, 1)")
            {
                moveElemenent.Perform();
            }
        }
    }
}
