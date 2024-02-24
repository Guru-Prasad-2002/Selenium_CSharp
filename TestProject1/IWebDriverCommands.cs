using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article_Automation
{
    class IWebDriverCommands
    {
        // IWebDriver methods
        // IWebDriver is an interface
        // It is implemented by ChromeDriver, FireFoxDriver, SafariDriver, and EdgeDriver

        // void IWebDriver.Close(); -> Closes only the current window; void return type
        // void IWebDriver.Quit(); -> Quits the browser itself
        // string IWebDriver.PageSource { get; } -> gets the page source (PageSource and Url is an attribute)
        // string IWebDriver.Url { get; set; } -> Gets and Sets browser url
        // string IWebDriver.Title { get; } - This method fetches the Title of the current page.
        // Accepts nothing as a parameter and returns a String value.

        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";

            string Title_name = driver.Title;
            int Title_length = Title_name.Length;
            Console.WriteLine("Title Name is " + Title_name);
            Console.WriteLine("Title Length is " + Title_length);

            string Page_source = driver.PageSource;
            int PagesourceLength = Page_source.Length;
            Console.WriteLine("Page Source is\n" + Page_source);
            Console.WriteLine("Page Source Length is " + PagesourceLength);

            driver.Quit();
        }
    }
}
