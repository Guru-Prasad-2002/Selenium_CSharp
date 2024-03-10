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
    class Implicit_Wait
    {
        IWebDriver driver;
        [SetUp]
        public void initBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/#";

            ////Implicit wait can be declared globally here
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void getErrorMessage()
        {
            //doubt ask
            //Implicit wait can be set inside the function also
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement username = driver.FindElement(By.Id("username"));
            username.SendKeys("username1");
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("username2");
            IWebElement signBtn = driver.FindElement(By.XPath("//input[@name = 'signin']"));
            signBtn.Click();
            IWebElement errorMessage = driver.FindElement(By.ClassName("alert-danger"));
            TestContext.Progress.WriteLine("ERROR MESSAGE IS");
            TestContext.Progress.WriteLine(errorMessage.Text);
        }

    }
}
