using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.NavigationBar
{
    partial class NavigationBar
    {

       public IWebElement ActiveModulesExpander => Driver.FindElement(By.XPath("//div[@class='category-nav']//*[normalize-space(text())='Активни модули']"));

       public IWebElement QaAutomationMayTrainingLink => Driver.FindElement(By.LinkText("Quality Assurance - октомври 2019"));
          
    }
}
