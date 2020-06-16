using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_1_GoogleSearchPages.GoogleHome
{
    public partial class GoogleHome : BasePage
    {
        public GoogleHome(IWebDriver driver)
            : base(driver)
        {
        }

        public void GoogleSearch(string text)
        {
            GoogleSearchField.SendKeys(text + Keys.Enter);
        }

        public override string Url => "https://google.com";
    }
}
