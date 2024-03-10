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
    //Locators supported - XPath,CSS,ID,Classname,Tagname,Name
    //Xpath and CSS are like queries to reach the point
    public class Locators
    {

        IWebDriver driver;
        [SetUp]
        public void InitBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/#";
        }
        [Test]
        public void idSelector()
        {
            IWebElement username = driver.FindElement(By.Id("username"));
            username.SendKeys("username1");
            Thread.Sleep(1000);
            username.Clear();
            username.SendKeys("username2");
        }

        //css selector - tagname[attribute='value']
        [Test]
        public void CssSelector()
        {
            IWebElement signBtn = driver.FindElement(By.CssSelector("input[name = 'signin']"));
            signBtn.Click();
        }
        //Xpath selector - //tagname[@attribute='value']
        [Test]
        public void xPathSelector()
        {
            IWebElement signBtn = driver.FindElement(By.XPath("//input[@name = 'signin']"));
            signBtn.Click();
        }

        [Test]
        public void grabbingErrorMessage()
        {
            IWebElement username = driver.FindElement(By.Id("username"));
            username.SendKeys("username1");
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("username2");
            IWebElement signBtn = driver.FindElement(By.XPath("//input[@name = 'signin']"));
            signBtn.Click();
            Thread.Sleep(2000);
            IWebElement errorMessage = driver.FindElement(By.ClassName("alert-danger"));
            TestContext.Progress.WriteLine("ERROR MESSAGE IS");
            TestContext.Progress.WriteLine(errorMessage.Text);
        }
        [Test]
        public void linkTextSelector()
        {
            IWebElement linkTxt = driver.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));
            String linkValue = linkTxt.GetAttribute("href");
            String expectedLinkValue = "https://rahulshettyacademy.com/documents-request";
            Assert.AreEqual(expectedLinkValue, linkValue);
        }

        [Test]
        //Traverse using XPath - Real XPath
        public void realXPath()
        {
            IWebElement checkBox = driver.FindElement(By.XPath("//div[@class='form-group'][5]/label/span/input"));
            checkBox.Click();
        }
        //.classname
        //#id
        
    }
}
