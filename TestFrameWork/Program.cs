using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace TestFrameWork
{
    class Program
    {
        static void Main(string[] args)
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\Anahit\Documents\Visual Studio 2017\Projects\TestFrameWork\geckodriver-v0.18.0-win32");
            // service.FirefoxBinaryPath = @"";
            IWebDriver driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl("https://goppa.benivo.com");
            driver.Quit();
        }
    }
}
