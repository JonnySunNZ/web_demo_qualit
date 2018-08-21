using System;
using Homework_34_Web_Automation_Testing_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]

    public class UnitTest1
    {
        [Test]

        public void Can_Go_To_MotorPage()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectMotors();
            Pages.MotorPage.selectCarForSale();
            Pages.CarSellPage.SelectCar();
        }

        public void Can_Go_To_MotorPage2()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectMotors();
            Pages.MotorPage.selectCarForSale();
            Pages.CarSellPage.SelectCar();
        }

        [TearDown]

        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
