using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAutomation
{
    public class MyAngularTest
    {
        private IWebDriver driver;

        public MyAngularTest(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this);

        }

        public void Goto()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/");
            Console.Read();
        }
    }
}
