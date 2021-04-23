using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AdvanceAutomation
{
    [TestClass]
    public class IFrameTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("file://C:/Users/mallu/source/repos/SeleniumTestApp/AdvanceAutomation/iframetest.html");

                new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(
                    d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

                var iframes = driver.FindElementsByTagName("iframe");
                Assert.IsTrue(iframes.Count == 2);

                driver.SwitchTo().Frame(0);
                var textFromzero = driver.PageSource.Contains("responsive sites");
                Assert.IsTrue(textFromzero);

                driver.SwitchTo().DefaultContent();

                driver.SwitchTo().Frame(1);
                var textFromOne = driver.PageSource.Contains("Online Bootcamp");
                Assert.IsTrue(textFromOne);

                //Console.Read();
            }
        }
    }
}
