using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.AutomationTfLProject.Setup;

namespace Test.AutomationTfLProject.Pages
{
    public class ChangeTimePage
    {
        private IWebDriver _driver;

        public ChangeTimePage(IWebDriver driver)
        {
            _driver = driver;
        }
        private By planAJourneyLink = By.XPath("//*[@id=\'jp-fav-content-home-\']/p/a");
        private By arrivingLink = By.XPath("//*[@id=\'plan-a-journey\']/fieldset/div[2]/div[2]/div[1]/ul/li[2]/label");
        private By fromField = By.Id("InputFrom");
        private By toField = By.Id("InputTo");
        private By changeTimeLink = By.XPath("//*[@id='plan-a-journey']/fieldset/div[2]/div[1]");
        private By planjourneyButton = By.Id("id=plan-journey-button");
        private By journeyResultsPage = By.XPath("//*[@id=\'hp-journey-planner\']/div/div[1]/div[2]");
        private By arrivingLabel = By.XPath("//*[@id='plan-a-journey']/div[1]/div[2]/span");

        public void ViewplanAJourneyLink()
        {
            IWebElement planAJourneyLocator = _driver.FindElement(planAJourneyLink);
        }

        public void ClickOnChangeTimeLink()
        {
            _driver.FindElement(arrivingLink).Click();
        }

            public void FillFromField(string InputFrom)
        {
            IWebElement fromLocator = _driver.FindElement(fromField);
            fromLocator.Clear();
            fromLocator.SendKeys(InputFrom);
        }

        public void FilltoField(string InputTo)
        {
            IWebElement toLocator = _driver.FindElement(toField);
            toLocator.Clear();
            toLocator.SendKeys(InputTo);
        }

        public void ClickOnArrivingLabel()
        {
            _driver.FindElement(arrivingLabel).Click();
        }

        public void ClickOnPlanJourneyButton()
        {
            _driver.FindElement(planjourneyButton).Click();
        }

        public void JourneyResultsPage()
        {
            _driver.FindElement(journeyResultsPage).Click();
        }

        public string ArrivingLabel()
        {
            return _driver.FindElement(arrivingLabel).Text.Trim();
        }

    }

}





