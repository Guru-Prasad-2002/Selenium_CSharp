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
    //There are 2 kinds of dropdown - Static and Dynamic Dropdown
    // Static dropdown - Cannot search for element by typing, we can only choose
    //Dynamic Dropdown - Give's us suggestions when we type the element we want to find
    class DropDown
    {
        public IWebDriver driver;
        public void initBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/#";
            driver.Manage().Window.Maximize();
            
        }
        [Test]
        public void staticDropdown()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement dropdown = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//select")));


            //we can use SelectElement class to select element in static dropdown

            SelectElement s = new SelectElement(dropdown);

            s.SelectByText("Teacher");
            Thread.Sleep(1000);
            s.SelectByValue("consult");
            Thread.Sleep(1000);
            s.SelectByIndex(1);
        }
        [Test]
        public void dynamicDropdown()
        {

        }

    }
}
