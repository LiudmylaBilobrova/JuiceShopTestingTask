using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace JuiceShopTests.PageObjects
{
    class LandingPagePageObject
    {
        private IWebDriver webdriver;

        private readonly By dismissWelcomePopupButton = By.XPath("//button[@aria-label='Close Welcome Banner']");

       
        public LandingPagePageObject(IWebDriver driver)
        {
            webdriver = driver;
        }

        public void DismissWelcomePopup()
        {
            //WaitUntil.PageLoadWait(webdriver, TestSettings.website);
            webdriver.FindElement(dismissWelcomePopupButton).Click();
        }
    }
}
