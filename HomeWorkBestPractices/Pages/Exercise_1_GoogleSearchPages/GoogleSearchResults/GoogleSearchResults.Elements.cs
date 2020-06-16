using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_1_GoogleSearchPages.GoogleSearchResults
{
    public partial class GoogleSearchResults
    {

        public IList<IWebElement> SearchResults => Driver.FindElements(By.XPath("//div[@class='r']/a"));

    }
}
