/* 
 * Explanation:
 * WebDriverWait is a class in Selenium that waits for a certain condition to be true before proceeding further.
 * It takes a driver instance and a timeout as parameters.
 * ExpectedConditions is a class in Selenium that provides a set of predefined conditions for use with WebDriverWait.
 * ElementToBeClickable is an expected condition that waits for an element to be clickable, which means it is present in the DOM and enabled.
 * TimeSpan.FromSeconds(10) specifies the maximum amount of time to wait for the condition to be true. In this case, it waits for up to 10 seconds.
 */

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
    class Browser_Navigation_Commands
    {
        // We have four Navigation commands
        // GoToUrl - Go to a specific URL
        // Back - Go back in the history of a page
        // Forward - Go forward in the history of a page
        // Refresh - Refresh a page
        // All have void return type

        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //IWebElement ele = driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[1]"));

            IWebElement ele = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[1]")));

            IWebElement clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(ele));

            Actions actions = new Actions(driver);
            actions.MoveToElement(ele).Click().Build().Perform();

            Thread.Sleep(5000);

            // driver.Navigate().Back();
            // driver.Navigate().Forward();
            driver.Navigate().Refresh();

            Thread.Sleep(3000);

            //driver.Quit();
        }
    }
}
