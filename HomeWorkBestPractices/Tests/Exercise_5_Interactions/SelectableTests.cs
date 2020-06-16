using HomeWorkBestPractices.Pages.Exercise_5_Interactions.SelectableGrid;
using NUnit.Framework;
using System.Linq;


namespace HomeWorkBestPractices.Tests.Exercise_5_Interactions
{
    class SelectableTests : BaseTest
    {
        private SelectableGrid _selectableGridPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _selectableGridPage = new SelectableGrid(Driver);
            _selectableGridPage.NavigateTo();
        }


        //Select some buttons and check if their color is blue
        [Test]
        public void Selectable1_SelectButtonsAndCheckTheirColor()
        {

            _selectableGridPage.SelectableGridButton.Click();

                       
            Builder
                  .Click(_selectableGridPage.Button("One"))
                  .Click(_selectableGridPage.Button("Three"))
                  .Click(_selectableGridPage.Button("Five"))
                  .Click(_selectableGridPage.Button("Seven"))
                  .Click(_selectableGridPage.Button("Nine"))
                  .Perform();

                        
            Assert.IsTrue(_selectableGridPage.GetColorsOfAllElements().All(x => x == "rgba(0, 123, 255, 1)"));
                       
        }

        //Hover with the cursor above an element and check if the color is correct (gray)
        [Test]
        public void Selectable2_HoverWithTheMouseAboveElementAndCheckTheColor()
        {
            _selectableGridPage.SelectableGridButton.Click();

            
            Builder
                  .MoveToElement(_selectableGridPage.Button("One"))
                  .Perform();

            
            var buttonOneColor = _selectableGridPage.Button("One").GetCssValue("background-color");

            
            Assert.IsTrue(buttonOneColor == "rgba(248, 249, 250, 1)");



        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
