using OpenQA.Selenium;
using StabilizeCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.QACoursePage
{
    public partial class QACoursePage
    {
        
       public WebElement QaAutomationMay2020Heading => Driver.FindElement(By.XPath("//h1[@class='text-center']"));

    }
}
