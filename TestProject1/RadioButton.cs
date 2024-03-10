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
    public class RadioButton
    {
        IWebDriver driver;
        [SetUp]
        public void initBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/radio-button";
        }
        [Test]
        public void radioBtn()
        {
            //using IList getting all the radiBtn's and storing it in list
            //selenium scan's from top left to bottom right

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(driver => (bool)((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState == 'complete'"));

            IList<IWebElement> rdos = driver.FindElements(By.XPath("//input[@type='radio']"));

            //Clicking using index
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("impressiveRadio")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", rdos[1]);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("yesRadio")));
            rdos[0].Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("noRadio")));
            rdos[2].Click();

            //Click using for loop 

            foreach(IWebElement RadioButton in rdos)
            {
                if (RadioButton.GetAttribute("id").Equals("impressiveRadio")) ;
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("impressiveRadio")));
                    RadioButton.Click();
                }

            }

        }

    }
}
