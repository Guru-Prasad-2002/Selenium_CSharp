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
    class Text_Box
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            IWebElement full_name, email, current_address, permanent_address, submit_button;

            Actions actions = new Actions(driver);

            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));

            full_name = driver.FindElement(By.Id("userName"));
            email = driver.FindElement(By.Id("userEmail"));
            current_address = driver.FindElement(By.Id("currentAddress"));
            permanent_address = driver.FindElement(By.Id("permanentAddress"));
            submit_button = driver.FindElement(By.Id("submit"));

            IWebElement clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(submit_button));



            full_name.SendKeys("John Doe");
            email.SendKeys("john@email.com");
            current_address.SendKeys("Karnataka,India");
            permanent_address.SendKeys("Karnataka,India");
            //actions.MoveToElement(clickableElement).Click().Build().Perform();
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", clickableElement);

        }
    }
}
