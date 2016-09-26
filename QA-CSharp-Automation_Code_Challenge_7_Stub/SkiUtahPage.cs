using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;

namespace QA_CSharp_Automation_Code_Challenge_7_Stub
{
    public class SkiUtahPage
    {
        
        private String filePath { get; set; }



        public SkiUtahPage(IWebDriver driver)
        {
            

        }

        public String readFile()
        {
            return File.ReadAllText("Dictionary.txt");
        }

        public void Crawl()
        {
            //TODO Crawl through the website
            //TODO Get all of the words
            //TODO Add them to dictionary
        }


        

    }
}
