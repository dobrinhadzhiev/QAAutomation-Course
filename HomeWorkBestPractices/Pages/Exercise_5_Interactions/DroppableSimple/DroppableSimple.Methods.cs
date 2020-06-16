using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.DroppableSimple
{
    public partial class DroppableSimple : BasePage
    {
        public DroppableSimple(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/droppable";


        public void MoveElementUntilColorChanges()
        {
            var moveElemenent = Builder
                                      .ClickAndHold(DraggableBox)
                                      .MoveByOffset(20, 0);

            //While the color of the drop. box is different from blue , the element is moved by 20 pixels
            while (DroppableBox.GetCssValue("background-color") != "rgba(70, 130, 180, 1)")
            {
                moveElemenent.Perform();
            }
        }
    }
}
