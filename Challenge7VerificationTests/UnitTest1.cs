using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using QA_CSharp_Automation_Code_Challenge_7_Stub;
using System.IO;

namespace Challenge7VerificationTests
{
    [TestClass]
    public class UnitTest1
    {
        TimeSpan thirtySeconds;
        ChromeOptions opt;
        ChromeDriver driver;
        SkiUtahPage page;

       [TestMethod]
        public void TestSetup()
        {
            thirtySeconds = new TimeSpan(0, 0, 30);
            opt = new ChromeOptions();
            driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), opt, thirtySeconds);
            driver.Url = "http://www.skiutah.com";
            driver.Navigate();
            page = new SkiUtahPage(driver);
            

        }
        [TestMethod]
        public void VerifyCrawl()
        {
            page.Crawl();
            //TODO Write a method that verifies that the Crawl() method in your SkiUtahPage class functions correctly.

        }

        [TestMethod]
        public void VerifyDictionary()
        {
            //TODO Write a method that verifies that the Dictionary file exists, and is not empty.
        }




    }
}
