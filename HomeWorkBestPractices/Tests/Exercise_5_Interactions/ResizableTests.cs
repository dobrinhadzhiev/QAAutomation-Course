using HomeWorkBestPractices.Pages.Exercise_5_Interactions.Resizable;
using NUnit.Framework;


namespace HomeWorkBestPractices.Tests.Exercise_5_Interactions
{
    class ResizableTests : BaseTest
    {
        private Resizable _rezizablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _rezizablePage = new Resizable(Driver);
            _rezizablePage.NavigateTo();
        }

        //Move the resize handle with more that 50pixels and check if the size of the box is 50 pixels smaller that the start size (200x200)
        [Test]
        public void Resizable1_BoxIsResizedToMinimumSize()
        {           

            Builder
                  .ClickAndHold(_rezizablePage.ResizableHandleUpperBox)
                  .MoveByOffset(-100, -100)
                  .Release()
                  .Perform();

            
            Assert.AreEqual("150px", _rezizablePage.UpperBox.GetCssValue("width"));
            Assert.AreEqual("150px", _rezizablePage.UpperBox.GetCssValue("height"));
        }


        //Resize the box to the maximum and check the size
        [Test]
        public void Resizable2_BoxIsResizedToMaximumSize()
        {
           
             Builder
                    .ClickAndHold(_rezizablePage.ResizableHandleUpperBox)
                    .MoveByOffset(300, 100)
                    .Release()
                    .Perform();

            
            Assert.AreEqual("500px", _rezizablePage.UpperBox.GetCssValue("width"));
            Assert.AreEqual("300px", _rezizablePage.UpperBox.GetCssValue("height"));

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
