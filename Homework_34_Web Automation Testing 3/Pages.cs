﻿using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_34_Web_Automation_Testing_3
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }

        public static ResultPage ResultPage
        {
            get
            {
                var resultPage = new ResultPage();
                PageFactory.InitElements(Browser.Driver, resultPage);
                return resultPage;
            }
        }

    }
}
