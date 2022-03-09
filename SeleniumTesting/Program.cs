using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a reference for our browser
            IWebDriver driver = new ChromeDriver();
            //navigating to your preferred site
            driver.Navigate().GoToUrl("https://www.google.com");
            //clicking the "agree" on the pop-up window
            IWebElement element = driver.FindElement(By.Id("L2AGLb"));
            element.Click();
            //sending keys to the search bar
            IWebElement element2 = driver.FindElement(By.Name("q"));
            element2.SendKeys("do a barrel roll");
            element2.SendKeys(Keys.Enter);
            //waiting and closing the browser
            Thread.Sleep(5000);
            driver.Close();


        }
    }
}
