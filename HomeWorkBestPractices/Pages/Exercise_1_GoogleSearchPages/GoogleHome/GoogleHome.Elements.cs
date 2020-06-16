using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_1_GoogleSearchPages.GoogleHome
{
    public partial class GoogleHome
    {

        public IWebElement GoogleSearchField => Driver.FindElement(By.Name("q"));

    }
}
