using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Test.AutomationTfLProject.Pages
{
    public class MyJourneys_NoLocationPage
    { 
        private IWebDriver _driver;

        public MyJourneys_NoLocationPage(IWebDriver driver)  
    
        {
        _driver = driver;
        }

        private By myjourneysTab = By.XPath("//*[@id='jp-fav-tab-home']/a");
        private By planajourneyLink = By.XPath("//*[@id=\'jp-fav-content-home-\']/p/a");
        private By fromField = By.Id("");
        private By toField = By.Id("InputTo");
        private By planjourneyButton = By.Id("id=plan-journey-button");
        private By journeyResults = By.XPath("//*[@id=\'hp-journey-planner\']/div/div[1]/div[2]");
        private By inputFromField = By.Id("InputFrom-error");

        public void MyjourneysTab()
        {
            _driver.FindElement(myjourneysTab).Click();
        }

        public void ClickOnPlanajourneyLink()
        {
            _driver.FindElement(planajourneyLink).Click();
        }

        public void FillFromField(string InputFrom)
        {
            IWebElement fromLocator = _driver.FindElement(fromField);
            fromLocator.Clear();
            fromLocator.SendKeys("");
        }

        public void FilltoField(string InputTo)
        {
            IWebElement toLocator = _driver.FindElement(toField);
            toLocator.Clear();
            toLocator.SendKeys(InputTo);
        }

        public void ClickOnPlanJourneyButton()
        {
            _driver.FindElement(planjourneyButton).Click();
        }

        public string InputfromField()
        {
            return _driver.FindElement(fromField).Text.Trim();  
        }


    }


}


