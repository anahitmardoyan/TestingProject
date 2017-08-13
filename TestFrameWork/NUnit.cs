using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using TestFrameWork.Lib;

namespace TestFrameWork
{
    class NUnit: BaseMethods
    {
        //FirefoxDriverService service;
        //IWebDriver driver;
        [SetUp]
        public void Init()
        {
            CreateDriver();
        }
        //{
          //  service = FirefoxDriverService.CreateDefaultService(@"C:\Users\Anahit\Documents\Visual Studio 2017\Projects\TestFrameWork\geckodriver-v0.18.0-win32");
            //driver = new FirefoxDriver(service);
        //}
        [Test]
        public void TestApp()
        {
            OpenWelcomePage();
            //IWebDriver driver = new FirefoxDriver();
            //driver.Url = "http://www.demoqa.com";
        }
        [TearDown]
        public void EndTest()
        {
            TearDown();
            //driver.Close();
        }
    }
}
