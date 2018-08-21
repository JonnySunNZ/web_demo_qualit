using System;
using TechTalk.SpecFlow;
using System.Threading;

namespace Homework_34_Web_Automation_Testing_3
{
    [Binding]
    public class SearchSteps
    {
        [Given(@"I am in home page")]
        public void GivenIAmInHomePage()
        {
            Pages.HomePage.Goto();
            Thread.Sleep(2000);
        }
        
        [When(@"I enter (.*)")]
        public void AndIEnter(string p0)
        {
            Pages.HomePage.ClickSearchBtn();
            Thread.Sleep(2000);
            Pages.HomePage.InputSearchCintent(p0);
            Thread.Sleep(2000);
            Pages.HomePage.ClickGoBtn();
            Thread.Sleep(2000);
        }
        
        [Then(@"I can see the result that I expect")]
        public void ThenICanSeeTheResultThatIExpect()
        {
            Pages.ResultPage.Assertion();
            Thread.Sleep(2000);
        }
    }
}
