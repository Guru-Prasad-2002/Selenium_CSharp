
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
    public class Annotation_intro
    {

        //Setup and TearDown will run for each tests
        [SetUp]
        public void Setup()
        {

            //matches chrome.exe version with chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver();
            TestContext.Progress.WriteLine("Setup Method 1");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("Test 1");
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("Test 2");
        }
        [TearDown]
        public void teardown()
        {
            TestContext.Progress.WriteLine("Inside TearDown Method");
        }
    }
}
