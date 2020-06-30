using HomeWorkBestPractices.Pages.Exercise_5_Interactions.Draggable;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.IO;

namespace HomeWorkBestPractices.Tests.Exercise_5_Interactions
{
    class DraggableTests : BaseTest
    {
        private Draggable _draggablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _draggablePage = new Draggable(Driver);
            _draggablePage.NavigateTo();
        }

        //Move the draggable object and check if its location changed
        [Test]
        public void Draggable1_ObjectLocationChanges_WhenMovedByOffset()
        {                   
            
            var positionYBefore = _draggablePage.DraggableBox.Location.Y;

           Builder
                .ClickAndHold(_draggablePage.DraggableBox.WrappedElement)
                .MoveByOffset(0, 100)
                .Perform();

            
            var positionYAfter = _draggablePage.DraggableBox.Location.Y;


            Assert.AreNotEqual(positionYBefore, positionYAfter);
        }


        //Move the draggable object to specified endpoint and check if it reached the endpoint
        [Test]
        public void Draggable2_ObjectIsMovedToSpecifiedEndpoint()
        {           
           
            var positionYBefore = _draggablePage.DraggableBox.Location.Y;
            var positionYEndpoint = positionYBefore + 20;

                       
            _draggablePage.MoveObjectToEndPoint(positionYEndpoint);
            
            var positionYAfter = _draggablePage.DraggableBox.Location.Y;

            
            Assert.AreEqual(positionYAfter, positionYEndpoint);

        }

        //Move the draggable object only on X axis and check if locationX changed and locationY didn't
        [Test]
        public void Draggable3_ObjectLocationChanges_WhenMovedOnlyOnXAxis()
        {
            
            var positionXBefore = _draggablePage.DraggableBox.Location.X;
            var positionYBefore = _draggablePage.DraggableBox.Location.Y;

            Builder
                  .ClickAndHold(_draggablePage.DraggableBox.WrappedElement)
                  .MoveByOffset(100, 0)
                  .Perform();

            
            double positionXAfter = _draggablePage.DraggableBox.Location.X;
            double positionYAfter = _draggablePage.DraggableBox.Location.Y;

            
            Assert.AreNotEqual(positionXBefore, positionXAfter);
            Assert.AreEqual(positionYBefore, positionYAfter);

        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\ScreenShots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
                
            }

            Driver.Quit();
        }
    }
}
