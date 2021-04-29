using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuiceShopTests
{
    class Exceptions
    {
        private IWebDriver webdriver;

        public Exceptions(IWebDriver driver)
        {
            webdriver = driver;
        }

        public void MakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)webdriver).GetScreenshot();
                const string fileName = "ScreenTestFailed_{0}";
                string path = @"D:\Users\lbilobrova\Desktop\Exceptions\";
                string timeStamp = System.DateTime.Now.ToString("yyyy-MM-dd-ss.fffff");
                screenshot.SaveAsFile(path + string.Format(fileName, timeStamp) + ".png");
            }
        }


    }
}
