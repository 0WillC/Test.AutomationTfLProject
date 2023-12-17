using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using Test.AutomationTfLProject.Pages;
using Test.AutomationTfLProject.Setup;
using OpenQA.Selenium;

namespace Test.AutomationTfLProject.StepDefinitions
{
    [Binding]
    public class MyJourneys_NoLocationStepDefinitions
    {
        private MyJourneys_NoLocationPage _myjourneys_NoLocationPage;
        private Context _context;

        public MyJourneys_NoLocationStepDefinitions(MyJourneys_NoLocationPage myJourneys_NoLocationPage, Context context)
        {
            _myjourneys_NoLocationPage = myJourneys_NoLocationPage;
            _context = context;   
        }

        [Given(@"that Journey planner widget is open")]
        public void GivenThatJourneyPlannerWidgetIsOpen()
        {
            _context.loadApplicationUnderTest();
        }

        [When(@"a user clicks on Plan A Journey Button")]
        public void WhenAUserClicksOnPlanAJourneyButton()
        {
            _myjourneys_NoLocationPage.ClickOnPlanajourneyLink();
        }

        [When(@"a user leaves From Address Field (.*)")]
        public void WhenAUserLeavesFromAddressFieldEmpty()
        {
            _myjourneys_NoLocationPage.FillFromField("");
        }

        [When(@"a user fills-in To field with (.*)")]
        public void WhenAUserFills_InToFieldWithCanaryWharf(string to)
        {
            _myjourneys_NoLocationPage.FilltoField(to);
        }

        [When(@"a user clicks on Plan My Journey Button")]
        public void WhenAUserClicksOnPlanMyJourneyButton()
        {
            _myjourneys_NoLocationPage.ClickOnPlanJourneyButton();
        }

        [Then(@"the user must receive a warning message '([^']*)' displayed under the text field")]
        public void ThenTheUserMustReceiveAWarningMessageDisplayedUnderTheTextField(string expectedResult)
        {
            string actualResulturl = _myjourneys_NoLocationPage.InputfromField();
            Assert.Equals(actualResulturl, expectedResult);

        }
         
        [AfterScenario]

        public void CloseApplicationUnderTest()
            {
                _context.ShutDownApplicationUnderTest();
            }
    }
}
