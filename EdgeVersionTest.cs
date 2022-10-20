using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;

namespace ND_15pam
{
    class ND_Edge
    {
        private static IWebDriver edgeDriver;
        [Test]

        public static void EdgeBrowserVersion()
        {
            string myBrowser = "Edge 106 on Windows 10";
            edgeDriver = new EdgeDriver();
            edgeDriver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            edgeDriver.Manage().Window.Maximize();
            edgeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement browserVersion = edgeDriver.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.IsTrue(myBrowser.Equals(browserVersion.Text));
            edgeDriver.Quit();
        }
    }

}
