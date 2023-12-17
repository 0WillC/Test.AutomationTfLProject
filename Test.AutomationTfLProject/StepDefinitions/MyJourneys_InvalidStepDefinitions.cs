using NUnit.Framework;
using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Test.AutomationTfLProject.Pages;
using Test.AutomationTfLProject.Setup;

namespace Test.AutomationTfLProject.StepDefinitions
{
    [Binding]
    public class MyJourneys_InvalidStepDefinitions
    {

        private MyJourneys_InvalidPage _myJourneys_InvalidPage;
        private Context _context;

        public MyJourneys_InvalidStepDefinitions(MyJourneys_InvalidPage myJourneys_InvalidPage, Context context)
        {
            _myJourneys_InvalidPage = myJourneys_InvalidPage;
            _context = context;
        }
        [Given(@"that journey planner widget is open")]
        public void GivenThatJourneyPlannerWidgetIsOpen()
        {
            _context.loadApplicationUnderTest();
        }

        [When(@"a user clicks on Plan A Journey Button")]
        public void WhenAUserClicksOnPlanAJourneyButton()
        {
            _myJourneys_InvalidPage.ClickOnPlanJourneyButton();
        }

        [When(@"a user fills-in Invalid From Address Field with (.*)")]
        public void WhenAUserFills_InFromAddressFieldWithCharlton(string from)
        {
            _myJourneys_InvalidPage.FillFromField(from);
        }

        [When(@"a user fills-in To Address Field with (.*)")]
        public void WhenAUserFills_InToAddressFieldWithLondonBridgeStation(string to)
        {
            _myJourneys_InvalidPage.FilltoField(to);
        }

        [When(@"a user clicks on Plan My Journey Button")]
        public void WhenAUserClicksOnPlanMyJourneyButton()
        {
            _myJourneys_InvalidPage.ClickOnPlanJourneyButton();
        }

        [Then(@"the user must receive a Field validation error(.*)")]
        public void ThenTheUserMustReceiveAFieldValidationError(string expectedResult)
        {
            string actualResult = _myJourneys_InvalidPage.JourneyResultsPage();
            Assert.Equals(actualResult, expectedResult);
            
        }
        [AfterScenario]

        public void CloseApplicationUnderTest()
        {
            _context.ShutDownApplicationUnderTest();

        }
    }
}
