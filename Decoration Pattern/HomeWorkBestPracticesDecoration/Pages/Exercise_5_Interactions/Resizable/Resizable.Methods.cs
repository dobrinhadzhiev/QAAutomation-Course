﻿using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.Resizable
{
    public partial class Resizable : BasePage
    {
        public Resizable(WebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/resizable";
    }
}
