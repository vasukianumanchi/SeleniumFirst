using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //Enter Text - Generic Method to control text box elements
        public static void Entertext(IWebDriver driver, string element, String value, String elementType)
        {
            if(elementType == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }
        //Click into a Button , CheckBox, option etc 
        public static void Click(IWebDriver driver, String element, String elementType)
        {
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();
        }
        //Selecting a dropdown control
        public static void selectDropDown(IWebDriver driver, String element, String value, String elementType)
        {
            if (elementType == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }

    }
}
