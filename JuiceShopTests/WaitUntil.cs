using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuiceShopTests
{
    public static class WaitUntil
    {
        /*
        public static void PageLoadWait(IWebDriver webDriver, string website)
        {
            try
            {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            }
            catch (Exception)
            {

                throw;
            }
        }
        */

        public static void WaitElement(IWebDriver webDriver, By locator)
        {
            var wait = new WebDriverWait(webDriver, new TimeSpan(0,0,30));
            var element = wait.Until(conditions =>
            {
                try
                {
                    var elementToBeDisplayed = webDriver.FindElement(locator);
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
            );
        }
    }
}
       