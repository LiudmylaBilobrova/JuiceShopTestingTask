using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;


namespace JuiceShopTests.PageObjects
{
    class MainPagePageObject : BaseTestClass
    {
        private readonly By addingAppleJuiceToBasketButton = By.XPath("//div[contains(text(),'Apple Juice')]/parent::div/parent::div/following-sibling::div/child::button[@aria-label='Add to Basket']");
        private readonly By addingBananaJuiceToBasketButton = By.XPath("//div[contains(text(), 'Banana Juice')]/parent::div/parent::div/following-sibling::div/child::button[@aria-label='Add to Basket']");


        public MainPagePageObject(IWebDriver driver)
        {
            webdriver = driver;
        }

        public void BuyBananaJuice()
        {
            Thread.Sleep(5000);
            webdriver.FindElement(addingBananaJuiceToBasketButton).Click(); 
        }
    }
}
