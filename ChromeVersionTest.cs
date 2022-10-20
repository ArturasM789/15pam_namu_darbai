using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ND_15pam
{
    class ND_15pam
    {
        private static IWebDriver chromeDriver;
        [Test]
        public static void ChromeBrowserVersion()
        {
            string myBrowser = "Chrome 106 on Windows 10";
            chromeDriver = new ChromeDriver();
            chromeDriver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement browserVersion = chromeDriver.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.IsTrue(myBrowser.Equals(browserVersion.Text));
            chromeDriver.Quit();
        }
    }

}
