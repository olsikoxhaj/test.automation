using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
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
    
    class  AutomationTest
    {
        //Reference per browserin
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void inicialisize()
        {
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/loginpagePractise/");
            Console.WriteLine("Open URL");
        }

        [Test]
        public void execiutetest()
        {
            IWebElement username = driver.FindElement(By.XPath("//input[@type='text' and @name='username' and @id='username']"));
            username.SendKeys("rahulshettyacademy");
           //By.CssSelector(#username)


            IWebElement Password = driver.FindElement(By.XPath("//input[@type='password' and @name='password' and @id='password']"));
            Password.SendKeys("learning");

            IWebElement Admin = driver.FindElement(By.XPath("//input[@type='radio' and @value='admin' and @id='usertype' and @name='radio' and @checked='checked']"));
            Admin.Click();

            var state = new SelectElement(driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div[5]/select")));
            state.SelectByValue("teach");

 //IWebDriver driver = new ChromeDriver();
 // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
 //Implict wait
            Thread.Sleep(2000);

            IWebElement checkbox = driver.FindElement(By.CssSelector("#terms"));
            checkbox.Click();

            Thread.Sleep(5000);

            //  new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(
            //ExpectedConditions.ElementToBeClickable(By.CssSelector("#signInBtn"))).Click();
            //Explicit Wait

            IWebElement SingIn = driver.FindElement(By.CssSelector("#signInBtn"));
            SingIn.Click();

            Console.WriteLine("Execuite Test");
        }


        [TearDown] 
        public void Cleanup()
        {
            driver.Close();
            Console.WriteLine("Close the Browser");
        }
    }
}
