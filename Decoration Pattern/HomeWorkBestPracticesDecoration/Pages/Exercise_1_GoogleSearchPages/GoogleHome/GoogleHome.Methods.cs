using OpenQA.Selenium;
using StabilizeCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_1_GoogleSearchPages.GoogleHome
{
    public partial class GoogleHome : BasePage
    {
        public GoogleHome(WebDriver driver)
            : base(driver)
        {
        }

        public void GoogleSearch(string text)
        {
            GoogleSearchField.SetText(text + Keys.Enter);
        }

        public override string Url => "https://google.com";
    }
}
