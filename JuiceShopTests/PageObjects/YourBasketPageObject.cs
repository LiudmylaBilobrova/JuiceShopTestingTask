using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace JuiceShopTests.PageObjects
{
    class YourBasketPageObject
    {
        private IWebDriver webdriver;

        private readonly By chekoutButton = By.XPath("//button[@id='checkoutButton']");
        private readonly By adressRadioButton = By.XPath("//label[@class='mat-radio-label']");
        private readonly By continueToDeliveryButton = By.XPath("//button[@aria-label='Proceed to payment selection']");
        private readonly By fastDeliveryRadioButton = By.XPath("//label[@for='mat-radio-41-input']");
        private readonly By cotinueToPaimentOptionsButton = By.XPath("//button[@aria-label='Proceed to delivery method selection']");
        private readonly By firstCardRadioButton = By.XPath("//label[@for='mat-radio-43-input']");
        private readonly By continueToOrderSummary = By.XPath("//button[@aria-label='Proceed to review']");
        private readonly By payOrderButton = By.XPath("//button[@id='checkoutButton']");
        private readonly By afterPurchaseText = By.XPath("//h1[@class='confirmation']");
        private readonly By emptyBasketValue = By.XPath("//span[contains(text(),'Your Basket')]/following-sibling::span[contains(text(),'0')]");

        public YourBasketPageObject(IWebDriver driver)
        {
            webdriver = driver;
        }

        public void Chekout()
        {
            Thread.Sleep(10000);
            //WaitUntil.WaitElement(webdriver, chekoutButton);
            webdriver.FindElement(chekoutButton).Click();
        }

        public void AddressSelection()
        {
            WaitUntil.WaitElement(webdriver, adressRadioButton);
            webdriver.FindElement(adressRadioButton).Click();
        }

        public void ContinueToDelivery()
        {
            webdriver.FindElement(continueToDeliveryButton).Click();
        }

        public void FastDeliverySelection()
        {
            webdriver.FindElement(fastDeliveryRadioButton).Click();
        }

        public void ContinueToPaimentOptions()
        {
            webdriver.FindElement(cotinueToPaimentOptionsButton).Click();
        }

        public void CardSelection()
        {
            webdriver.FindElement(firstCardRadioButton).Click();
        }

        public void ContinueToReview()
        {
            webdriver.FindElement(continueToOrderSummary).Click();
        }

        public void PayOrder()
        {
            webdriver.FindElement(payOrderButton).Click();
        }

        public bool CheckTextAfterPurchase(string luckyPuchaseText)
        {
            WaitUntil.WaitElement(webdriver, afterPurchaseText);
            return webdriver.FindElement(afterPurchaseText).Text.Contains(luckyPuchaseText);
        }

        public bool CkeckBusketIsEmpty(string zeroValue)
        {
            return webdriver.FindElement(emptyBasketValue).Text.Contains(zeroValue);
        }
    }
}
