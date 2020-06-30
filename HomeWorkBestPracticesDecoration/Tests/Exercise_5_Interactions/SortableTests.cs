using HomeWorkBestPractices.Pages.Exercise_5_Interactions.SortableGrid;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;

namespace HomeWorkBestPractices.Tests.Exercise_5_Interactions
{
    class SortableTests : BaseTest
    {
        private SortableGrid _sortableGridPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _sortableGridPage = new SortableGrid(Driver);
            _sortableGridPage.NavigateTo();
        }


        //Move button 9 to 1 and check the text in element 1
        [Test]
        public void Sortable1_SwitchTwoElementsAndCheckTheResult()
        {
            _sortableGridPage.SortableGridButton.Click();                      
            
            Builder
                  .ClickAndHold(_sortableGridPage.ButtonNum(9).WrappedElement)
                  .MoveToElement(_sortableGridPage.ButtonNum(1).WrappedElement)
                  .Release()
                  .Perform();
                                   
            Assert.AreEqual("Nine", _sortableGridPage.ButtonNum(1).Text);

        }


        //Switch two buttons and check if their location is switched too
        [Test]
        public void Sortable2_SwitchTwoElementsAndCheckIfTheirLocaitionIsSwitched()
        {
            _sortableGridPage.SortableGridButton.Click();


            var positionButtonOneBefore = _sortableGridPage.Button("One").Location;
            var positionButtonTwoBefore = _sortableGridPage.Button("Two").Location;

            Builder
                  .ClickAndHold(_sortableGridPage.Button("One").WrappedElement)
                  .MoveToElement(_sortableGridPage.Button("Two").WrappedElement)
                  .Release()
                  .Perform();
            
            
            var positionButtonOneAfter = _sortableGridPage.Button("One").Location;
            var positionButtonTwoAfter = _sortableGridPage.Button("Two").Location;

            Assert.AreEqual(positionButtonTwoBefore, positionButtonOneAfter);
            Assert.AreEqual(positionButtonOneBefore, positionButtonTwoAfter);


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
