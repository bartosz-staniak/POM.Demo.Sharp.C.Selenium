// using MbUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObjectPatternDemo
{
    [TestClass]

    public class InitialPage
    {
        public IWebDriver webDriver; // there wasn't "public"
        public InitialPage(IWebDriver driver) 
        {
            webDriver = driver; // there was "this."webDriver
            this.search();
            this.WaitTenSec();
        }


        public static By topBanner = By.XPath("XPathGoesHere");
        public static By searchField = By.Id("IdGoesHere");
        public static By searchFieldSubmit = By.Name("NameGoesHere");

        public void search()
        {
            webDriver.FindElement(InitialPage.searchField).SendKeys("StringGoesHere");
            webDriver.FindElement(InitialPage.searchFieldSubmit).Click();
            WaitTenSec();
        }


        public void WaitTenSec()
        {
            WebDriverWait webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

    }


    public class ResultsPage : InitialPage
    {
        public ResultsPage(IWebDriver driver) : base (driver)
        {
            this.sort();
            this.WaitTenSec();
        }

        public static By sortProducts = By.Id("IdGoesHere");

        public void sort()
        {
            webDriver.FindElement(ResultsPage.sortProducts).Click();
            WaitTenSec();
        }

    }

}