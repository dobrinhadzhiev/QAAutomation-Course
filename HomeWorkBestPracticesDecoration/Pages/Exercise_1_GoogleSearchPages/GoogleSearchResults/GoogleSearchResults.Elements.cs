using OpenQA.Selenium;
using StabilizeCore;
using System.Collections.Generic;


namespace HomeWorkBestPractices.Pages.Exercise_1_GoogleSearchPages.GoogleSearchResults
{
    public partial class GoogleSearchResults
    {

        public IList<WebElement> SearchResults => Driver.FindElements(By.XPath("//div[@class='r']/a"));

    }
}
