using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace e_albania
{
    [TestClass]
    public class CrossTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            // change the driver from chrome to firefox
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://rahulshettyacademy.com/loginpagePractise/");

            Thread.Sleep(3000);
            //add edge browser 
            chromeDriver.Quit();

            //add a link
            IWebDriver firefoxDriver = new FirefoxDriver();
            firefoxDriver.Navigate().GoToUrl("https://rahulshettyacademy.com/loginpagePractise/");

            Thread.Sleep(3000);

            firefoxDriver.Quit();
        }


    }
}