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
    [TestFixture]
    public class DemoQA
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Elements()
        {
            WebElements webElements = new WebElements(driver);
            webElements.NavigateToCard("elements");
            webElements._textBoxButton.Click();
            webElements._userNameTextBox.SendKeys("Vinay");
            webElements._emailTextBox.SendKeys("name@gmail.com");
            webElements._currentAddressTextBox.SendKeys("#1307,KHB Platnium");
            webElements._permanentAddressTextBox.SendKeys("#1307,KHB Platnium");
            webElements._submitButton.SendKeys(Keys.Enter);
            Assert.True(webElements._nameLabel.Text.Contains("Vinay"));
            Assert.True(webElements._emailLabel.Text.Contains("name@gmail.com"));
            Assert.True(webElements._currentAddressLabel.Text.Contains("KHBPlatnium"));
            Assert.True(webElements._permanentAddressLabel.Text.Contains("KHBPlatnium"));

            webElements.NavigateToCard("checkbox");
            webElements._homeCheckBox.SendKeys(Keys.Enter);
            Assert.True(webElements._homeCheckBox.Selected);

            webElements.NavigateToCard("webtables");
            webElements._addNewRecordButton.Click();
            webElements.RegistrationForm("Vinay", "P", "v@gmail.com", "23", "1000", "MCA");

            webElements.NavigateToCard("buttons");
            Actions actions = new Actions(driver);
            actions.ContextClick(webElements._rightClickButton).Perform();
            Assert.True(webElements._rightClickLabel.Text.Contains("You have done a right click"));

            webElements.NavigateToCard("upload-download");
            webElements._chooseFileButton.SendKeys("C:\\Users\\pattansh-1\\Downloads\\Vinay_Travel\\BusTicket_Return.pdf");
            webElements._downloadButton.Click();

            webElements.NavigateToCard("alerts");
            webElements._confirmButtonButton.Click();
            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();
            driver.SwitchTo().DefaultContent();

            webElements.NavigateToCard("auto-complete");
            webElements._autoCompleteSingleContainer.SendKeys("Red");
            webElements._autoCompleteSingleContainer.SendKeys(Keys.ArrowDown);

            webElements.NavigateToCard("date-picker");
            webElements._datePickerMonthYearInput.SendKeys("05312023");

            webElements.NavigateToCard("tool-tips");
            Actions builder = new Actions(driver);
            builder.MoveToElement(webElements._toolTipButton)
            .Click().Build().Perform();

            webElements.NavigateToCard("droppables");
            builder = new Actions(driver);
            var dragAndDrop = builder.ClickAndHold(webElements._draggable).MoveToElement(webElements._droppable).Release(webElements._draggable).Build();
            dragAndDrop.Perform();

            webElements.NavigateToCard("browser-windows");
            webElements._newTabButton.Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Console.WriteLine("Current window id: " + driver.CurrentWindowHandle);
            Console.WriteLine("Page title in second tab is: " + driver.Title);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            webElements = new WebElements(driver);
            webElements._newWindowButton.Click();
            string newWindowHandle = driver.WindowHandles.Last();
            var newWindow = driver.SwitchTo().Window(newWindowHandle);

            string expectedNewWindowTitle = "https://demoqa.com/sample";
            Assert.AreEqual(expectedNewWindowTitle, newWindow.Title);
            driver.SwitchTo().DefaultContent();

        }

        [Test]
        public void BookStore()
        {
            WebElements webElements = new WebElements(driver);
            webElements.NavigateToCard("books");
            webElements._loginButton.Click();
            webElements._BookUserNameTextBox.SendKeys("VinayP");
            webElements._BookPasswordTextBox.SendKeys("Vinay@2023");
            webElements._loginButton.Click();
            Assert.True(webElements._userNameValue.Text.Contains("VinayP"), "User is not logged in");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
