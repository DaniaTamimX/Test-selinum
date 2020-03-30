using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Test_selinum
{
    class TestDemo
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome\\Application");
        }
        [Test]
        public void Test()
        {
            driver.Url = "https://www.google.se";
        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
