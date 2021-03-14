using JuiceShopTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

/// <summary>
/// Task: Selenium + PageObject
/// Create 2 tests.
/// https://juice-shop-ozar.herokuapp.com/
/// Juice Shop credentials:
/// admin@juice-sh.op
/// admin123
/// Test 1 - Enter invalid password and check that warning about invalid password appears
/// Test 2 - Log system in using specified login and password and make a purchase (Note: the cards are fake).
/// Check that card is empty after the purchase has been performed
/// Should be used:
/// - PageObject Pattern
/// - Implicit and Explicit waits
/// - If test failed - screenshot should be made
/// </summary>

namespace JuiceShopTests
    {
    [TestFixture]
    public class JuiceShopTests : BaseTestClass
    {
        /*
        [Test]
        public void InvalidLoginTest()
        {
        
        }
        */

        [Test]
        public void MakingPurchaseTest()
        {
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            var landingPage = new LandingPagePageObject(webdriver);
            landingPage
                .DismissWelcomePopup();

            var headerFooter = new HeaderFooterPageObject(webdriver);
            headerFooter
                .SignIn();

            var loginPopup = new LoginPopupPageObject(webdriver);
            loginPopup
                .Login(TestSettings.validLogin, TestSettings.validPassword);

            var mainPage = new MainPagePageObject(webdriver);
            mainPage
                .BuyBananaJuice();
            mainPage
                .DismissCookies();
            mainPage
                .NavigateToNextPage();
            mainPage
                .ByMug();
            mainPage
                .OpenShoppingCart();

            var yourBasket = new YourBasketPageObject(webdriver);
            yourBasket
                .Chekout();

        }
    }
}