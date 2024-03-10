using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using WebDriverManager.DriverConfigs.Impl;
using SeleniumExtras.PageObjects;

namespace Rahul_Shetty_Udemy
{
    class Gmail_Attachment_Automation
    {
        [Test]
        public void Test()
        {
            //Create a new chrome driver
            IWebDriver driver = new ChromeDriver();

            //Navigate to gmail login page
            driver.Navigate().GoToUrl("https://accounts.google.com/v3/signin/identifier?ifkv=ATuJsjzsAOcrXujnwLcYzzMaI-yGj1apHaYTqO3AZpq0zoJRZeFhWO1AQ6DnhkB5JGM_FqOqYzQ7&service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-1878183365%3A1708964464100646&theme=glif");

            //Create an explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            //Wait until the entire page is loaded
            wait.Until(driver => (bool)((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState == 'complete'"));

            //Find the user name
            IWebElement userName = driver.FindElement(By.XPath("//*[@id=\"identifierId\"]"));

            //Send userName
            userName.SendKeys("1by20cs154@bmsit.in");

            //Find Next button and wait till the button is clickable
            IWebElement nextButton = driver.FindElement(By.XPath("//*[@id=\"identifierNext\"]/div/button"));
            IWebElement clickableElement1 = wait.Until(ExpectedConditions.ElementToBeClickable(nextButton));

            //Perform JavaScript Click
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", clickableElement1);

            //Wait for password field in next page
            By elementOnNextPageLocator = By.XPath("//*[@id=\"password\"]/div[1]/div/div[1]/input");
            IWebElement password_field = wait.Until(ExpectedConditions.ElementIsVisible(elementOnNextPageLocator));

            //Wait until the next page is completly loaded
            wait.Until(driver => (bool)((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState == 'complete'"));

            //Send password to Gmail
            password_field.SendKeys("prasad@2002");

            //Find Next button and wait till the button is clickable
            IWebElement nextButton2 = driver.FindElement(By.XPath("//*[@id=\"passwordNext\"]/div/button"));
            IWebElement clickableElement2 = wait.Until(ExpectedConditions.ElementToBeClickable(nextButton2));

            //Perform JavaScript Click
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", clickableElement2);

            //Wait for a element in next page
            By waitComposeButton = By.XPath("/html/body/div[8]/div[3]/div/div[2]/div[2]/div[1]/div[1]/div/div");
            IWebElement composeButton = wait.Until(ExpectedConditions.ElementIsVisible(waitComposeButton));

            //Wait until the next page is completly loaded
            wait.Until(driver => (bool)((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState == 'complete'"));

            //Wait until the compose button is clickable
            IWebElement clickableElement3 = wait.Until(ExpectedConditions.ElementToBeClickable(composeButton));

            //Perform JavaScriopt click on compose button
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", clickableElement3);

            // wait till receipent can be added and then add receipent
            By to_field_xpath = By.XPath("//input[@class='agP aFw' and @peoplekit-id='BbVjBd' and @autocapitalize='off' and @autocorrect='off' and @spellcheck='false']");
            IWebElement to_field = wait.Until(ExpectedConditions.ElementIsVisible(to_field_xpath));

            //Add receiver
            to_field.SendKeys("gurujissrr@gmail.com");
            to_field.SendKeys(Keys.Enter);

            
            //I am assuming after this time attach button would be visible
            By attach_button_xpath = By.XPath("//div[@class='a1 aaA aMZ' and @style='user-select: none;']");
            IWebElement attach_button = wait.Until(ExpectedConditions.ElementToBeClickable(attach_button_xpath));

            //Perform JS click on attach button
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", attach_button);
            
        }
    }
}
