using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.SelectableGrid
{
    public partial class SelectableGrid : BasePage
    {
        public SelectableGrid(WebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/selectable";


        public string[] GetColorsOfAllElements()
        {
            var buttonOneColor = Button("One").GetCssValue("background-color");
            var buttonThreeColor = Button("Three").GetCssValue("background-color");
            var buttonFiveColor = Button("Five").GetCssValue("background-color");
            var buttoSevenColor = Button("Seven").GetCssValue("background-color");
            var buttonNineColor = Button("Nine").GetCssValue("background-color");
            
            string[] selectedElements = new[] { buttonOneColor, buttonThreeColor, buttonFiveColor, buttoSevenColor, buttonNineColor };

            return selectedElements;
        }
    }
}
