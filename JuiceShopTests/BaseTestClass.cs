﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;


namespace JuiceShopTests
{
    public class BaseTestClass
    {
        protected IWebDriver webdriver;

        [OneTimeSetup]
        protected void DoBeforeAllTests()
        {
            //webdriver = new ChromeDriver();
        }

        [SetUp]
        protected void DoBeforeEachTest()
        {
            webdriver = new ChromeDriver();
            webdriver.Manage().Cookies.DeleteAllCookies();
            webdriver.Navigate().GoToUrl(TestSettings.website);
            webdriver.Manage().Window.Maximize();
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        protected void DoAfterAllTests()
        {
        
        }

        [TearDown]
        protected void DoAfterEachTest()
        {
            //webdriver.Quit();
            //webdriver.Dispose();
        }
    }
}
