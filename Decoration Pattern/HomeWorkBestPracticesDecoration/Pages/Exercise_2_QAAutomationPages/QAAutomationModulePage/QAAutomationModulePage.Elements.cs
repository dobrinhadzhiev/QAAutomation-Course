using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.QAAutomationModulePage
{
    public partial class QAAutomationModulePage
    {
        public WebElement QAAutomationCourseLink => Driver.FindElement(By.XPath("//h4[normalize-space(text())='QA Automation']//ancestor::div[@class='box-content']/preceding-sibling::div"));
    }
}
