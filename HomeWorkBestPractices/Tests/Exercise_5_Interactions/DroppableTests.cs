﻿using HomeWorkBestPractices.Pages.Exercise_5_Interactions.DroppableAccept;
using HomeWorkBestPractices.Pages.Exercise_5_Interactions.DroppableSimple;
using NUnit.Framework;


namespace HomeWorkBestPractices.Tests.Exercise_5_Interactions
{
    class DroppableTests : BaseTest
    {
        private DroppableSimple _droppableSimplePage;
        private DroppableAccept _droppableAcceptPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _droppableSimplePage = new DroppableSimple(Driver);
            _droppableAcceptPage = new DroppableAccept(Driver);
            _droppableSimplePage.NavigateTo();
        }

        //Drop the draggable box in the droppable box and check if the color of the droppable box has changed
        [Test]
        public void Droppable1_DraggableBoxColorChanges_WhenDroppedInTheDroppableBox()
        {           
                       
            var droppableBoxColorBefore = _droppableSimplePage.DroppableBox.GetCssValue("background-color");

            Builder
                  .DragAndDrop(_droppableSimplePage.DraggableBox, _droppableSimplePage.DroppableBox)
                  .Perform();
                       
            var droppableBoxColorAfter = _droppableSimplePage.DroppableBox.GetCssValue("background-color");

            
            Assert.AreNotEqual(droppableBoxColorBefore, droppableBoxColorAfter);
            
        }

        //Drop the Not Acceptable draggable box in the droppable box and check if the color of the droppable box hasn't changed
        [Test]
        public void Droppable2_NotAcceptableDraggableBoxIsNotChaningingTheColor_WhenDroppedInTheDroppableBox()
        {
            _droppableSimplePage.DroppableAcceptTab.Click();
        
            
            var droppableBoxColorBefore = _droppableAcceptPage.DroppableBox.GetCssValue("background-color");

            Builder
                  .ClickAndHold(_droppableAcceptPage.NotAcceptabledraggableBox)
                  .MoveToElement(_droppableAcceptPage.DroppableBox)
                  .Release()
                  .Perform();

            
            var droppableBoxColorAfter = _droppableAcceptPage.DroppableBox.GetCssValue("background-color");

            
            Assert.AreEqual(droppableBoxColorBefore, droppableBoxColorAfter);
            
        }

        //Move the draggable object until the color of the droppable object changes and check the text in the dropppable box
        [Test]
        public void Droppable3_DraggableBoxIsMoved_UntilTheColorOfTheDroppableBoxIsChanged()
        {
            
            _droppableSimplePage.MoveElementUntilColorChanges();
            
            Assert.AreEqual("Dropped!", _droppableSimplePage.DroppableBoxText.Text);

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
