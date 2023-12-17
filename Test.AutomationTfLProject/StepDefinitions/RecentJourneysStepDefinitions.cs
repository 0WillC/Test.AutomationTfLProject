using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using Test.AutomationTfLProject.Pages;
using Test.AutomationTfLProject.Setup;
using OpenQA.Selenium;

namespace Test.AutomationTfLProject.StepDefinitions
{

    [Binding]

    public class RecentJourneysStepDefinitions
    {
        private RecentsJourneysPage _recentsJourneysPage;
        private Context _context;

        public RecentJourneysStepDefinitions(RecentsJourneysPage recentsJourneysPage, Context context)
        {
            _recentsJourneysPage = recentsJourneysPage;
            _context = context;
        }

        [Given(@"a user is on the widget page")]
        public void GivenAUserIsOnTheWidgetPage()
        {
            _context.loadApplicationUnderTest();
        }
        [Given(@"all cookies are enabled")]
        public void GivenAllCookiesAreEnabled()
        {
            _recentsJourneysPage.AcceptAllCookies();
        }
        [When(@"a user clicks on Recents tab on the widget")]
        public void WhenAUserClicksOnRecentsTabOnTheWidget()
        {
            _recentsJourneysPage.RecentsTab();
        }

        [Then(@"the user must see a list of recently planned journeys")]
        public void ThenTheUserMustSeeAListOfRecentlyPlannedJourneys(string expectedResult)
        {
            string actualResulturl = _recentsJourneysPage.RecentsContentHomePage();
            Assert.Equals(actualResulturl, expectedResult);

        }
        [AfterScenario]

        public void CloseApplicationUnderTest()
        {
            _context.ShutDownApplicationUnderTest();

        }
    }
}
