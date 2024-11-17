using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using static OpenQA.Selenium.BiDi.Modules.Log.Entry;

namespace Automation_Task.StepDefinitions
{
    [Binding]
    public class BuyingItemFromSauceLabStepDefinitions
    {
        IWebDriver driver;

        [Given(@"User is on the Sauce Labs page")]
        public void GivenUserIsOnTheSauceLabsPage()
        {
            //setting up browser in incognitomoe
            //var options = new EdgeDriver();
            //options.AddArgument("--inprivate");

            // Set up Edge options to use incognito mode
            var options = new EdgeOptions();
            options.AddArgument("--inprivate");

            // Initialize the Edge driver with the options
            IWebDriver driver = new EdgeDriver(options);

            // Navigate to the URL
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            // Maximize the browser window
            driver.Manage().Window.Maximize();


        }

        [When(@"User log in with valid credentials")]
        public void WhenUserLogInWithValidCredentials()
        {
            
        }

        [When(@"User verify that the product catalog is dispalayed")]
        public void WhenUserVerifyThatTheProductCatalogIsDispalayed()
        {
            
        }

        [When(@"User add a T-shirt to the shopping cart")]
        public void WhenUserAddAT_ShirtToTheShoppingCart()
        {
            
        }

        [When(@"User proceed to the checkout")]
        public void WhenUserProceedToTheCheckout()
        {
            
        }

        [When(@"User provide valid shipping details")]
        public void WhenUserProvideValidShippingDetails()
        {
            
        }

        [When(@"User complete the purchase")]
        public void WhenUserCompleteThePurchase()
        {
            
        }

        [Then(@"User should see a confirmation message for the successful order")]
        public void ThenUserShouldSeeAConfirmationMessageForTheSuccessfulOrder()
        {
            
        }
    }
}
