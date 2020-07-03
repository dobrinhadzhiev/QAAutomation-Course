using OpenQA.Selenium;
using StabilizeCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.SortableGrid
{
    public partial class SortableGrid : BasePage
    {
        public SortableGrid(WebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/sortable";
    }
}
