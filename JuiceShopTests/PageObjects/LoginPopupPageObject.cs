using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace JuiceShopTests.PageObjects
{
    class LoginPopupPageObject
    {
        private IWebDriver webdriver;

        private readonly By emailInputButton = By.XPath("//input[@id='email']");
        private readonly By passwordInputButton = By.XPath("//input[@id='password']");
        private readonly By loginButton = By.XPath("//button[@id='loginButton']");
        private readonly By invalidLoginText = By.XPath("//div[@class='error ng-star-inserted']");


        public LoginPopupPageObject(IWebDriver driver)
        {
            webdriver = driver;
        }

        public MainPagePageObject Login(string validLogin, string validPassword)
        {
            webdriver.FindElement(emailInputButton).SendKeys(validLogin);
            webdriver.FindElement(passwordInputButton).SendKeys(validPassword);
            webdriver.FindElement(loginButton).Click();

            return new MainPagePageObject(webdriver);
        }

        public bool CheckMessageAfterInvalidLogin(string invalidLoginMessage)
        {
            return webdriver.FindElement(invalidLoginText).Text.Contains(invalidLoginMessage);
        }
    }
}
