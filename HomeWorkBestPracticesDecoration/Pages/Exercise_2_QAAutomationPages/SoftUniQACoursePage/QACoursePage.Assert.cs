using NUnit.Framework;
using OpenQA.Selenium;
using StabilizeCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.QACoursePage
{
    public partial class QACoursePage : BasePage
    {
        public QACoursePage(WebDriver driver) : base(driver)
        {
        }

        public void AssertHeadingHasCorrectText(string expectedHeadingText)
        {
            Assert.AreEqual(expectedHeadingText, QaAutomationMay2020Heading.Text);
        }
    }
}
