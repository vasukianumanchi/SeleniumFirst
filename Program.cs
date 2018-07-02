using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        // create reference for our browser
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {

        }
        [SetUp]
        public void Initialize()
        {
            //Navigate to Google page
            // driver.Navigate().GoToUrl("http://www.google.com");
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=login");
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.selectDropDown(driver,"TitleId","Mr.","Id");
            SeleniumSetMethods.Entertext(driver, "Initial", "ExecuteAutomation", "Name");
            Console.WriteLine("Value of Title is " + SeleniumGetMethods.GetTextFromDDL(driver, "TitleId", "Id"));
            Console.WriteLine("Value of Initial is " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));
            SeleniumSetMethods.Click(driver,"Save","Name");

        }
        [TearDown]
        public void CleanUp()
        {
           // driver.Close();
            Console.WriteLine("Closed Browser");
        }
    }
}
