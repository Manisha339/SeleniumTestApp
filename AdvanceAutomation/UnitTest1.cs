using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceAutomation
{
    /// <summary>
    /// Summary description for test
    /// </summary>
    [TestClass]
    public class AboutUsPOMTest
    {
        [TestMethod]
        public void TestPOM()
        {
            using (var driver = new ChromeDriver())
            {
                AboutUsPOM about = new AboutUsPOM(driver);
                about.Goto();
                Assert.IsTrue(driver.PageSource.Contains("About Simplilearn"));
            }
        }
    }
}
