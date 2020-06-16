using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.QACoursePage
{
    public partial class QACoursePage : BasePage
    {
        public QACoursePage(IWebDriver driver) : base(driver)
        {
        }

        public void AssertHeadingHasCorrectText(string expectedHeadingText)
        {
            Assert.AreEqual(expectedHeadingText, QaAutomationMay2020Heading.Text);
        }
    }
}
