﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_1_GoogleSearchPages.GoogleSearchResults
{
    public partial class GoogleSearchResults : BasePage
    {
        public GoogleSearchResults(IWebDriver driver)
            : base(driver)
        {
        }

        public void ClickOnFirstResult()
        {
            SearchResults[0].Click();
        }
    }
}
