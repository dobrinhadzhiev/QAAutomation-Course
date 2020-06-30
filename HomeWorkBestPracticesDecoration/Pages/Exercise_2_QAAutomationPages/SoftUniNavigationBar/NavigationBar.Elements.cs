using OpenQA.Selenium;
using StabilizeCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.NavigationBar
{
    partial class NavigationBar
    {

       public WebElement ActiveModulesExpander => Driver.FindElement(By.XPath("//div[@class='category-nav']//*[normalize-space(text())='Активни модули']"));

       public WebElement QaAutomationMayTrainingLink => Driver.FindElement(By.LinkText("Quality Assurance - октомври 2019"));
          
    }
}
