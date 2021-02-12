// using MbUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace PageObjectPatternDemo
{
    [TestClass]
    public class FirstPage
    {
        IWebDriver Webdriver;

        public FirstPage()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("disable-infobars");
            Webdriver = new ChromeDriver(@"DriverLocationGoesHere", chromeOptions);
            Webdriver.Navigate().GoToUrl("URLgoesHERE");
            Webdriver.Manage().Window.Maximize();
            WebDriverWait webDriverWait = new WebDriverWait(Webdriver, TimeSpan.FromSeconds(50));
        }

        [TestMethod]
        public void FirstTest()
        {  
            InitialPage initialPage = new InitialPage(Webdriver);
           

            Assert.AreEqual("TitleGoesHere", Webdriver.Title);


            Webdriver.Quit();
        }
    }

}