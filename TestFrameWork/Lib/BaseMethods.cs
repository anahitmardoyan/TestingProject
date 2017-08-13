using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
//using NUnit.Framework;

namespace TestFrameWork.Lib
{
    public class BaseMethods
    {
        public FirefoxDriverService service;
        public IWebDriver driver;
        public String url;
        public String login;
        public String pass;

        public void SetBaseURL(String url)
        {
            this.url = url;
        }

        public void SetCredentials(String username, String password)
        {
            this.login = username;
            this.pass = password;
        }

        public void CreateDriver()
        {
            service = FirefoxDriverService.CreateDefaultService(@"C:\Users\Anahit\Documents\Visual Studio 2017\Projects\TestFrameWork\geckodriver-v0.18.0-win32");
            driver = new FirefoxDriver(service);
        }

        public void OpenWelcomePage()
        {
            driver.Navigate().GoToUrl("https://goppa.benivo.com");
        }

        protected By GetLocator(String methodName, String searchElement)
        {
            By locator = null;
            switch (methodName)
            {
                case "id":
                    locator = By.Id(searchElement);
                    break;
                case "xpath":
                    locator = By.XPath(searchElement);
                    break;
                case "tagName":
                    locator = By.TagName(searchElement);
                    break;
                case "className":
                    locator = By.ClassName(searchElement);
                    break;
                case "linkText":
                    locator = By.LinkText(searchElement);
                    break;
                case "cssSelector":
                    locator = By.CssSelector(searchElement);
                    break;
                default:
                    locator = By.Id(searchElement);
                    break;
            }

            return locator;
        }

       // public void LoginToAccount()
       // {
            
        //}

        public void ClickOnElement(String method, String webElement)
        {
            By locator = GetLocator(method, webElement);
            driver.FindElement(locator).Click();
        }

        public void SendValueToElement(String method, String webElement, String value)
        {
            By locator = GetLocator(method, webElement);
            IWebElement textBox = driver.FindElement(locator);
            textBox.Clear();
            textBox.SendKeys(Keys.Insert);
            textBox.SendKeys(value);
        }

        public void VerifyElementIsPresent(String method, String webElement)
        {
            Boolean isPresent = driver.FindElement(GetLocator(method, webElement)).Size.Width > 0;
            Console.WriteLine(isPresent);
            //Object.Equals(isPresent, true);



        }

        public void VerifyTheTextOfElementContains(String method, String Webelement, String partialText)
        {
            String actualText = driver.FindElement(GetLocator(method, Webelement)).Text;
            Console.WriteLine(actualText);
            //driver
        }

        public void TearDown()
        {
            driver.Quit();
        }


    }
}
