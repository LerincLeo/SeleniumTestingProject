using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumTesting
{
    class Program
    {
        //creating a reference for our browser
        IWebDriver driver = new ChromeDriver();


        [SetUp]
        public void BrowserCheckup()
        {
            //navigating to your preferred site
            driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("Opened the browser and went to Google.");
        }

        [Test]
        public void TestBrowser()
        {
            //clicking the "agree" on the pop-up window
            IWebElement element = driver.FindElement(By.Id("L2AGLb"));
            element.Click();
            Console.WriteLine("Accepted the pop-up window for security.");

            //sending keys to the search bar
            IWebElement element2 = driver.FindElement(By.Name("q"));
            element2.SendKeys("do a barrel roll");
            Console.WriteLine("Searched out...");

            //clicking "Enter" to start the search
            element2.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            IWebElement element3 = driver.FindElement(By.ClassName("twQ0Be"));
            element3.Click();
            Thread.Sleep(5000);
            IWebElement element4 = driver.FindElement(By.XPath("//tp-yt-paper-button[@id='button']//*[text()='I Agree']"));
            element4.Click();

        }

        [TearDown]
        public void BrowserCleanup()
        {
            //waiting and closing the browser
            Thread.Sleep(5000);
            driver.Close();
            Console.WriteLine("Closed the program!");           
        }
    }
}
