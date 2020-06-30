using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using StabilizeCore;
using System;


namespace HomeWorkBestPractices.Pages
{
    public class BasePage
    {

        public WebDriver Driver { get; }

        public virtual string Url { get;}

        public Actions Builder { get; }

      //  public WebDriverWait Wait { get; }
        

        public BasePage(WebDriver driver)
        {
            Driver = driver;
           // Driver.WrappedDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Builder = new Actions(driver.WrappedDriver);          
        }

        public void NavigateTo()
        {
            Driver.Navigate(Url);
        }

                
    }
}
