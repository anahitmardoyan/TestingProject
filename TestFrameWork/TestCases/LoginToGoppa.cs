using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using TestFrameWork.Lib;

namespace TestFrameWork.TestCases
{
    class LoginToGoppa: BaseMethods
    {
        string URL = "https://goppa.benivo.com";
        string Login = "anahit.mardoyan@gmail.com";
        string Password = "Test123";

        [SetUp]
        public void Init()
        {
            SetBaseURL(URL);
            SetCredentials(Login, Password);
        }

        [Test]
        public void LogIn()
        {
            CreateDriver();
            OpenWelcomePage();
            VerifyElementIsPresent("xpath", "//div[@id='btnDiv']/button");
            ClickOnElement("xpath", "//div[@id='btnDiv']/button");
            SendValueToElement("id", "username", "anahit.mardoyan@gmail.com");
            SendValueToElement("id", "password", "Test123");
            ClickOnElement("xpath", "//input[@value='Login']");
            System.Threading.Thread.Sleep(4000);
            //VerifyElementIsPresent("cssSelector", ".vipicon-profile-icon-lightblue");
            //VerifyElementIsPresent("xpath", "//span[@class='vipicon-profile-icon-lightblue']");
            //VerifyTheTextOfElementContains("className", "fc-vip-top-banner-title", "Hi Anahit,");
        }
    }
}
