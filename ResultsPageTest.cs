// using MbUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace PageObjectPatternDemo
{
    [TestClass]
    public class ResultsPageTest
    {
        IWebDriver Webdriver;

        public ResultsPageTest()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("disable-infobars");
            Webdriver = new ChromeDriver(@"DriverLocationGoesHere", chromeOptions);
            Webdriver.Navigate().GoToUrl("URLgoesHere");
            Webdriver.Manage().Window.Maximize();
            WebDriverWait webDriverWait = new WebDriverWait(Webdriver, TimeSpan.FromSeconds(50));
        }

        [TestMethod]
        public void ResultsTest()
        {
            ResultsPage resultsPage = new ResultsPage(Webdriver);

	    Assert.AreEqual("TitleGoesHere", Webdriver.Title);

            Webdriver.Quit();

        }

    }

}