using NUnit.Framework;
using OpenQA.Selenium;
using StabilizeCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_1_GoogleSearchPages.SeleniumPage
{
    public class SeleniumPage : BasePage
    {
        public SeleniumPage(WebDriver driver) : base(driver)
        {
        }

        public void AssertPageURL(string expectedURL)
        {
            Assert.AreEqual(expectedURL, Driver.WrappedDriver.Url);
        }

        public void AssertPageTitle(string expectedTitle)
        {
            Assert.AreEqual(expectedTitle, Driver.WrappedDriver.Title);
        }

    }
}
