using System;

using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
 
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.IO;
using OpenQA.Selenium.Support.UI;

namespace SceleniumDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Search()
        {


            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://www.google.com/");
                IWebElement query = driver.FindElement(By.Name("q"));

                query.SendKeys("Cheese");

                query.Submit();


            }

        }
    }
}