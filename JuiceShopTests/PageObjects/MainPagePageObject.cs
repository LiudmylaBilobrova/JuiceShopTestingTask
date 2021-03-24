using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace JuiceShopTests.PageObjects
{
    class MainPagePageObject
    {

        private IWebDriver webdriver;

        private readonly By addingAppleJuiceToBasketButton = By.XPath("//div[contains(text(),'Apple Juice')]/parent::div/parent::div/following-sibling::div/child::button[@aria-label='Add to Basket']");
        private readonly By addingBananaJuiceToBasketButton = By.XPath("//div[contains(text(), 'Banana Juice')]/parent::div/parent::div/following-sibling::div/child::button[@aria-label='Add to Basket']");
        private readonly By dismissCookieButton = By.XPath("//a[@class='cc-btn cc-dismiss']");
        private readonly By nextPageArrowButton = By.XPath("//button[@aria-label='Next page']");
        private readonly By addingMugToBasketButton = By.XPath("//div[contains(text(), 'OWASP Juice Shop Mug ')]/parent::div/parent::div/following-sibling::div/child::button[@aria-label='Add to Basket']");
        private readonly By yourBasketButton = By.XPath("//button[@aria-label='Show the shopping cart']");


        public MainPagePageObject(IWebDriver driver)
        {
            webdriver = driver;
        }
        
        public void BuyBananaJuice()
        {
            /*var wait = new WebDriverWait(webdriver, new TimeSpan(0,0,30));
            wait.Until(c => c.FindElement(addingBananaJuiceToBasketButton));*/
            WaitUntil.WaitElement(webdriver, addingAppleJuiceToBasketButton);
            webdriver.FindElement(addingBananaJuiceToBasketButton).Click(); 
        }
        
        public void DismissCookies()
        {
            webdriver.FindElement(dismissCookieButton).Click();
        }

        public void NavigateToNextPage()
        {
            webdriver.FindElement(nextPageArrowButton).Click();
        }

        public void ByMug()
        {
            webdriver.FindElement(addingMugToBasketButton).Click();
        }

        public YourBasketPageObject OpenShoppingCart()
        {

            webdriver.FindElement(yourBasketButton).Click();

            return new YourBasketPageObject(webdriver);
        }
    }
}
