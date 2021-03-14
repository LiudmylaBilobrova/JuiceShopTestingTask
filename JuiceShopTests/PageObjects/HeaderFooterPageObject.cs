using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;



namespace JuiceShopTests.PageObjects
{
    class HeaderFooterPageObject
    {
        private IWebDriver webdriver;

        private readonly By accountButton = By.XPath("//button[@id='navbarAccount']");
        private readonly By loginAccountButton = By.XPath("//button[@id='navbarLoginButton']");



        public HeaderFooterPageObject(IWebDriver driver)
        {
            webdriver = driver;
        }

        public LoginPopupPageObject SignIn()
        {
            webdriver.FindElement(accountButton).Click();
            webdriver.FindElement(loginAccountButton).Click();

            return new LoginPopupPageObject(webdriver);
        }
    }
}
