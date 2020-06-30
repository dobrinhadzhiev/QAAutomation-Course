using OpenQA.Selenium;
using StabilizeCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.Homepage
{
    public partial class SoftUniHomePage
    {

        public WebElement HomePageTrainingsButton => Driver.FindElement(By.XPath("//*[@id='header-nav']//span[normalize-space(text())='Обучения']"));

               

    }
}
