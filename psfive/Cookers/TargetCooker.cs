using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace psfive
{
    class TargetCooker : StoreCooker
    {
        public void Cook()
        {
            bool packageSecured = false;

            while(!packageSecured)
            {
                try
                {
                    var chromeOptions = new ChromeOptions();
                    //chromeOptions.AddArguments("headless");
                    //var driver = new ChromeDriver(chromeOptions);
                    var driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://www.target.com/p/powerxl-5qt-single-basket-air-fryer-black/-/A-79910186");
                    Thread.Sleep(2000);
                    var pickupButton = driver.FindElementByXPath("//button[@data-test='orderPickupButton']");
                    pickupButton.Click();
                    Thread.Sleep(2000);

                    var declineCoverageButton = driver.FindElementByXPath("//button[@data-test='espModalContent-declineCoverageButton']");
                    declineCoverageButton.Click();
                    Thread.Sleep(2000);

                    var checkoutButton = driver.FindElementByXPath("//button[@data-test='addToCartModalViewCartCheckout']");
                    checkoutButton.Click();
                    Thread.Sleep(4000);

                    var checkoutButton2 = driver.FindElementByXPath("//button[@data-test='checkout-button']");
                    checkoutButton2.Click();
                    Thread.Sleep(1000);

                    var usernameInputField = driver.FindElementByXPath("//input[@name='username']");
                    usernameInputField.SendKeys(Constants.TargetEmail);
                    var passwordInputField = driver.FindElementByXPath("//input[@name='password']");
                    passwordInputField.SendKeys(Constants.TargetPassword);
                    Thread.Sleep(4000);

                    var signInButton = driver.FindElementByXPath("//button[@id='login']");
                    signInButton.Click();
                    Thread.Sleep(4000);

                    var creditCardCVVInput = driver.FindElementByXPath("//input[@credit-card-cvv-input']");
                    creditCardCVVInput.SendKeys(Constants.TargetCreditCardCVV);
                    Thread.Sleep(2000);

                    var placeOrder = driver.FindElementByXPath("//button[@data-test='placeOrderButton']");
                    //placeOrder.Click();
                    packageSecured = true;
                }
                catch
                {
                    //do nothing right now
                }
            }
        }
    }
}
