using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_34_Web_Automation_Testing_3
{
    public class MotorPage
    {
        [FindsBy(How = How.CssSelector, Using = "tbody tr td.make_item_col0 a")]
        private IWebElement carname;

        [FindsBy(How = How.LinkText, Using = "Cars for sale")]
        private IWebElement carsale;

        public string Alfa
        {
            get { return carname.Text; }
        }

        public void selectCarForSale()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Cars for sale")));

            carsale.Click();
        }
    }
}
