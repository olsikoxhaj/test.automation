using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace test.automation.selenium
{

    class FindAndPrint
    {

        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void inicialisize()
        {
            driver.Navigate().GoToUrl("https://e-albania.al/Default.aspx");

        }
        [Test]
        public void execiutetest()
        {
            driver.Navigate().GoToUrl("https://e-albania.al/Default.aspx");

            
            IWebElement pageTitleElement = driver.FindElement(By.XPath("//h5[@class='card-title ealb-card-title mt-0' and @onclick=\"clickCategory(1048, 'FAMILJA');\"]"));


            string pageTitle = pageTitleElement.Text;

            if (pageTitle == "FAMILJA")
            {
                Console.WriteLine("Titulli i faqes është 'FAMILJA'.");
            }
            else
            {
                Console.WriteLine("Titulli i faqes nuk është 'FAMILJA'.");
            }

           
            driver.Quit();
        }
    }
}

    
