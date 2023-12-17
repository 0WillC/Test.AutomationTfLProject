using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Test.AutomationTfLProject.Pages;
using Test.AutomationTfLProject.Setup;
using NUnit.Framework;


namespace Test.AutomationTfLProject.StepDefinitions
{
    [Binding]
    public class MyJourneysStepDefinitions 
    {  
        
       private MyJourneysPage _myJourneysPage;
       private Context _context;

        public MyJourneysStepDefinitions(MyJourneysPage myJourneysPage, Context context)
        {
            _myJourneysPage = myJourneysPage;
            _context = context;

        }
        [Given(@"that the tfl application is loaded")]
        public void GivenThatTheTflAplicationIsLoaded()
        {
            _context.loadApplicationUnderTest();
        }

        [When(@"a user clicks on Myjourneys tab")]
        public void WhenAUserClicksOnMyjourneysTab()
        {
            _myJourneysPage.ClickOnPlanJourneyButton();
        }

        [When(@"a user clicks on plan a journey link")]
        public void WhenAUserClicksOnPlanAJourneyLink()
        {
            _myJourneysPage.ClickOnPlanajourneyLink();
        }

        [When(@"a user fills-in From field with (.*)")]
        public void WhenAUserFillsFromField(string from)
        {
            _myJourneysPage.FillFromField(from);
        }

        [When(@"a user fills-in To field with (.*)")]
        public void WhenAUserFillsToField(string to)
        {
            _myJourneysPage.FilltoField(to);
        }

        [When(@"a user clicks on Plan journey button")]
        public void WhenAUserClicksOnPlanJourneyButton()
        {
            _myJourneysPage.ClickOnPlanJourneyButton();
        }

        [Then(@"results headline journey results page must be displayed")]
        public void ThenResultsHeadlineJourneyResultsMustBeDisplayed(string expectedResult)
        {
            string actualResulturl = _myJourneysPage.JourneyResultsPage();
            Assert.Equals(actualResulturl, expectedResult);
                          
        }
        [AfterScenario]

        public void CloseApplicationUnderTest()
        {
            _context.ShutDownApplicationUnderTest();
        
        }

    }
}
    


