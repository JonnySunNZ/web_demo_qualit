using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework_34_Web_Automation_Testing_3
{
    public class HomePage
    {
        static string Url = "http://qualit.co.nz/";

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/a[2]")]
        private IWebElement searchBtn;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/form/fieldset/div/div/input")]
        private IWebElement inputField;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/form/fieldset/input")]
        private IWebElement goBtn;

        public void ClickSearchBtn()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 15));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/a[2]")));
         
            searchBtn.Click();
        }

        public void InputSearchCintent(string inputContent)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 15));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div[2]/form/fieldset/div/div/input")));

            inputField.SendKeys(inputContent);
        }

        public void ClickGoBtn()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 15));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div[2]/form/fieldset/input")));

            goBtn.Click();
        }

        public void Goto()
        {
            Browser.Goto(Url);
        }
    }
}
