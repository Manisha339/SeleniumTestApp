using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceAutomation
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestPOM()
        {
            using (var driver = new ChromeDriver())
            {
                MyAngularTest app = new MyAngularTest(driver);
                app.Goto();
                var regTitle = driver.PageSource.Contains("Registration Form");
                Assert.IsTrue(regTitle);
                driver.FindElementByName("firstname").SendKeys("Manisha");
                driver.FindElementByName("lastname").SendKeys("Allu");
                driver.FindElementByName("email").SendKeys("allu@gmail.com");
                driver.FindElementByName("password").SendKeys("123456789");
                driver.FindElementByName("password1").SendKeys("12356789");
                driver.FindElementByName("Submit").Click();
                if(driver.PageSource.Contains("Form Submitted by Manisha Allu"))
                {
                    System.Threading.Thread.Sleep(5000);
                    driver.Navigate().GoToUrl("https://www.simplilearn.com");
                }
            }
        }
    }
}
        
