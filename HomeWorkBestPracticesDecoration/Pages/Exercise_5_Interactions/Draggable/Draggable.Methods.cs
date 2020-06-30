using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.Draggable
{
    public partial class Draggable : BasePage
    {
        public Draggable(WebDriver driver) : base(driver)
        {               
        }

        public override string Url => "http://www.demoqa.com/dragabble";
             
        
        public void MoveObjectToEndPoint(int endPoint)
        {
            var moveToEndLocation = Builder
                                            .ClickAndHold(DraggableBox.WrappedElement)
                                            .MoveByOffset(0, 4)
                                            .Build();

            // The object is moved by 4 pixels until it reaches the End Point
            while (DraggableBox.Location.Y != endPoint)
            {
                moveToEndLocation.Perform();
            }
        }
    }
}
