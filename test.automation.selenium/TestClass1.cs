using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Test_Cross1
{
    [TestClass]
    public class CrossTest
    {
        [TestMethod]
        public void TestMethod2()
        {
            string browser = Environment.GetEnvironmentVariable("BROWSER");

            if (browser != null && browser.Equals("chrome", StringComparison.OrdinalIgnoreCase))
            {
                // Konfigurimi i Chrome
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://e-albania.al/Default.aspx");

            
                string pageTitle = driver.Title;

                
                string expectedTitle = "FAMILJA";
                Assert.AreEqual(expectedTitle, pageTitle, "FAMILJA.");

                
                driver.Quit();
            }
            else if (browser != null && browser.Equals("firefox", StringComparison.OrdinalIgnoreCase))
            {
                // Konfigurimi i Firefox
                IWebDriver driver = new FirefoxDriver();
                driver.Navigate().GoToUrl("https://e-albania.al/Default.aspx");

                
                string pageTitle = driver.Title;

               
                string expectedTitle = "FAMILJA";
                Assert.AreEqual(expectedTitle, pageTitle, "FAMILJA.");
                driver.Quit();
            }
            else
            {
                Console.WriteLine("Print.Title");
            }
        }
    }
}