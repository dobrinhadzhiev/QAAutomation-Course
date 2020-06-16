﻿using AutoFixture;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Reflection;



namespace HomeWorkBestPractices.Tests
{    
     [TestFixture]

    public class BaseTest
    {
        protected Fixture Fixture { get; set; }
        protected Actions Builder { get; set; }
        protected IWebDriver Driver { get; set; }
        

        public void Initialize()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Manage().Window.Maximize();
            Fixture = new Fixture();
            Builder = new Actions(Driver);
        }
    }
}