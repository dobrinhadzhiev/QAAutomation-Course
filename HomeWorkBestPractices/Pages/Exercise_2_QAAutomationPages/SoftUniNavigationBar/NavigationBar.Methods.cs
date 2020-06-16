using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.NavigationBar
{
    partial class NavigationBar : BasePage
    {

        public NavigationBar(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateToQAAutmationModulePage()
        {
            ActiveModulesExpander.Click();
            QaAutomationMayTrainingLink.Click();
        }

    }
}
