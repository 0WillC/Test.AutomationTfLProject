using System;
using TechTalk.SpecFlow;
using Test.AutomationTfLProject.Pages;
using Test.AutomationTfLProject.Setup;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Test.AutomationTfLProject.StepDefinitions
{
    [Binding]
    public class ChangeTimeLinkStepDefinitions
    {
        private ChangeTimePage _changeTimePage;
        private Context _context;

        public ChangeTimeLinkStepDefinitions(ChangeTimePage changeTimePage, Context context)
        {
            _changeTimePage = changeTimePage;
            _context = context;

        }
        [Given(@"that a user is on the journey planner page")]
        public void GivenThatAUserIsOnTheJourneyPlannerPage()
        {
            _context.loadApplicationUnderTest();
        }

        [When(@"a user a user views the change time link")]
        public void WhenAUserAUserViewsTheChangeTimeLink()
        {
            _changeTimePage.ClickOnChangeTimeLink();
        }

        [Then(@"the user must see the Arriving link")]
        public void ThenTheUserMustSeeTheArrivingLink()
        {
            _changeTimePage.ClickOnArrivingLabel();
        }

        [Given(@"a user is on the Journey Planner page")]
        public void GivenAUserIsOnTheJourneyPlannerPage()
        {
            _changeTimePage.ViewplanAJourneyLink();
        }
        
            [Given(@"a user fills-in Fromfield with (.*)")]
        public void GivenAUserFills_InFromfieldWithPaddington(string from)
        {
            _changeTimePage.FillFromField(from);
        }

        [Given(@"a user fills-in Tofield with (.*)")]
        public void GivenAUserFills_InTofieldWithLondonBridge(string to)
        {
            _changeTimePage.FilltoField(to);
        }

        [When(@"a user selects the Arriving option from the change time link")]
        public void WhenAUserSelectsTheArrivingOptionFromTheChangeTimeLink()
        {
            _changeTimePage.ClickOnArrivingLabel();
        }

        [When(@"a user clicks on the plan journey button")]
        public void WhenAUserClicksOnThePlanJourneyButton()
        {
            _changeTimePage.ClickOnPlanJourneyButton();
        }

        [Then(@"the user must see the planned journey based on arrival time")]
        public void ThenTheUserMustSeeThePlannedJourneyBasedOnArrivalTime(string expectedResult)
        {
            string actualResulturl = _changeTimePage.ArrivingLabel();
            Assert.Equals(actualResulturl, expectedResult);
        }

        [AfterScenario]

        public void CloseApplicationUnderTest()
        {
            _context.ShutDownApplicationUnderTest();
        }
        
    }
}
