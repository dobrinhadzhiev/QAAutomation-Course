using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.QACoursePage
{
    public partial class QACoursePage
    {
        
       public IWebElement QaAutomationMay2020Heading => Driver.FindElement(By.XPath("//h1[@class='text-center']"));

    }
}
