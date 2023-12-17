using System;
using TechTalk.SpecFlow;
using Test.AutomationTfLProject.Pages;
using Test.AutomationTfLProject.Setup;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Test.AutomationTfLProject.StepDefinitions
{
    [Binding]
    public class JourneyResultsEditStepDefinitions
    {
        private JourneyResultsEditPage _journeyresultsEditPage;
        private Context _context;

        public JourneyResultsEditStepDefinitions(JourneyResultsEditPage journeyresultsEditPage, Context context)
        {
            _journeyresultsEditPage = journeyresultsEditPage;
            _context = context;
        }

        [Given(@"that a user is on the Journey Results page")]
        public void GivenThatAUserIsOnTheJourneyResultsPage()
        { 
            _journeyresultsEditPage.ViewjourneyResults();
        }

        [When(@"a user click on (.*)")]
        public void WhenAUserClicksOnLink()
        {
            _journeyresultsEditPage.EditJourneyLink();
        }

        [When(@"a user changes InputTo field value from (.*)")]
        public void WhenAUserChangesInputToFieldValueFromTo(string to)
        {
            _journeyresultsEditPage.FillToField(to);

        }

        [When(@"a user clicks on (.*)")]
        public void WhenAUserClicksOnButton()
        {
            _journeyresultsEditPage.UpdateJourneyButton();
        }

        [Then(@"the user must see the result as edited on the journey results page")]
        public void ThenTheUserMustSeeTheResultAsEditedOnTheJourneyResultsPage(string expectedResult)
        {
            string actualResult = _journeyresultsEditPage.JourneyResultPage();
            Assert.Equals(actualResult, expectedResult);
                          
        }

        [AfterScenario]

        public void CloseApplicationUnderTest()
        {
            _context.ShutDownApplicationUnderTest();

        }
    }
}
