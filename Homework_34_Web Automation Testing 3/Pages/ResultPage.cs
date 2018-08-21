using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_34_Web_Automation_Testing_3
{
    public class ResultPage
    {

        public void Assertion()
        {

            Assert.IsTrue(Browser.Driver2.FindElement(By.XPath("/html/body")).Text.Contains("Meet our team") ||
                Browser.Driver2.FindElement(By.XPath("/html/body")).Text.Contains("Jenny Martin"));
        }


    }
}
