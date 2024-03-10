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
    public class WebElements
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "userName")]
        public IWebElement _userNameTextBox;

        [FindsBy(How = How.Id, Using = "userEmail")]
        public IWebElement _emailTextBox;

        [FindsBy(How = How.Id, Using = "currentAddress")]
        public IWebElement _currentAddressTextBox;

        [FindsBy(How = How.Id, Using = "permanentAddress")]
        public IWebElement _permanentAddressTextBox;

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement _submitButton;

        [FindsBy(How = How.XPath, Using = "//ul[@class='menu-list']//li[@id='item-0']")]
        public IWebElement _textBoxButton;

        [FindsBy(How = How.Id, Using = "permanentAddress")]
        public IWebElement _permanentAddressLabel;

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement _nameLabel;

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement _emailLabel;

        [FindsBy(How = How.Id, Using = "currentAddress")]
        public IWebElement _currentAddressLabel;

        [FindsBy(How = How.Id, Using = "tree-node-home")]
        public IWebElement _homeCheckBox;

        [FindsBy(How = How.Id, Using = "addNewRecordButton")]
        public IWebElement _addNewRecordButton;

        [FindsBy(How = How.Id, Using = "rightClickBtn")]
        public IWebElement _rightClickButton;

        [FindsBy(How = How.Id, Using = "rightClickMessage")]
        public IWebElement _rightClickLabel;

        [FindsBy(How = How.Id, Using = "uploadFile")]
        public IWebElement _chooseFileButton;

        [FindsBy(How = How.Id, Using = "downloadButton")]
        public IWebElement _downloadButton;

        [FindsBy(How = How.Id, Using = "tabButton")]
        public IWebElement _newTabButton;

        [FindsBy(How = How.Id, Using = "windowButton")]
        public IWebElement _newWindowButton;

        [FindsBy(How = How.Id, Using = "confirmButton")]
        public IWebElement _confirmButtonButton;

        [FindsBy(How = How.Id, Using = "autoCompleteSingleContainer")]
        public IWebElement _autoCompleteSingleContainer;

        [FindsBy(How = How.Id, Using = "datePickerMonthYearInput")]
        public IWebElement _datePickerMonthYearInput;

        [FindsBy(How = How.Id, Using = "toolTipButton")]
        public IWebElement _toolTipButton;

        [FindsBy(How = How.Id, Using = "draggable")]
        public IWebElement _draggable;

        [FindsBy(How = How.Id, Using = "droppable")]
        public IWebElement _droppable;

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement _loginButton;

        [FindsBy(How = How.Id, Using = "userName")]
        public IWebElement _BookUserNameTextBox;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement _BookPasswordTextBox;

        [FindsBy(How = How.Id, Using = "userName-value")]
        public IWebElement _userNameValue;

        public WebElements(IWebDriver webDriver)
        {
            this.driver = webDriver;
            //PageFactory.InitElements(webDriver, this);
        }

        public void MenuClick(int index)
        {
            driver.FindElement(By.XPath(String.Format("//ul[@class='menu-list']//li[@id='item-{0}']),index"))).Click();

        }

        public void NavigateToCard(string card)
        {
            driver.Navigate().GoToUrl(string.Format("https://demoqa.com/{0}", card));
        }

        public void RegistrationForm(string firstName, string lastName, string email, string age, string salary, string dept)
        {
            driver.FindElement(By.Id("firstName")).Clear();

            driver.FindElement(By.Id("firstName")).SendKeys(firstName);

            driver.FindElement(By.Id("lastName")).Clear();

            driver.FindElement(By.Id("lastName")).SendKeys(lastName);


            driver.FindElement(By.Id("userEmail")).Clear();

            driver.FindElement(By.Id("userEmail")).SendKeys(email);


            driver.FindElement(By.Id("age")).Clear();

            driver.FindElement(By.Id("age")).SendKeys(age);


            driver.FindElement(By.Id("salary")).Clear();

            driver.FindElement(By.Id("salary")).SendKeys(salary);

            driver.FindElement(By.Id("department")).Clear();

            driver.FindElement(By.Id("department")).SendKeys(dept);

            driver.FindElement(By.Id("submit")).Click();

        }


    }
}
