using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Exemplo.Test.MVC
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void Register()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:54593/Product/Register");
            driver.Manage().Window.Maximize();

            IWebElement name = driver.FindElement(By.Id("name"));
            IWebElement price = driver.FindElement(By.Id("price"));

            name.SendKeys("Product 1");
            price.SendKeys("2.50");

            var enter = driver.FindElement(By.Id("enter"));
            enter.Equals("Enter");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);

            enter.Click();

            driver.Quit();
        }
    }
}
