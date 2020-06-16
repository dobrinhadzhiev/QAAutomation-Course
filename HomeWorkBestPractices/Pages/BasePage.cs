using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;


namespace HomeWorkBestPractices.Pages
{
    public class BasePage
    {

        public IWebDriver Driver { get; }
        public virtual string Url { get;}
        public Actions Builder { get; }
        

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Builder = new Actions(driver);          
        }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(Url);
        }

                
    }
}
