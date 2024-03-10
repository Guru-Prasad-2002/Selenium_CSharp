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
    
    class RS_15
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Title_Url()
        {
            driver.Url = "https://rahulshettyacademy.com/locatorspractice/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
        }
        [Test]
        public void Assert_Equal()
        {
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/loginpagePractise/#");
            IWebElement link = driver.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));
            String actual_url=link.GetAttribute("href");
            String expected_url = "https://rahulshettyacademy.com/documents-request";
            Assert.AreEqual(expected_url, actual_url);
        }

        [TearDown]
        public void teardown()
        {
            Thread.Sleep(5000);
            driver.Quit();
        }
    }

}
