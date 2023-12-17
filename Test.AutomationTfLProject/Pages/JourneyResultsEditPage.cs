using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AutomationTfLProject.Pages
{
    public class JourneyResultsEditPage
    {
        private IWebDriver _driver;

        public JourneyResultsEditPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private By editJourneyLink = By.XPath("//*[@id=\'plan-a-journey\']/div[1]/div[3]/a/span");
        private By toField = By.Id("InputTo");
        private By updateJourneyButton = By.Id("plan-journey-button");
        private By journeyResults = By.XPath("//*[@id=\'hp-journey-planner\']/div/div[1]/div[2]");
        private By toLabel = By.XPath("//*[@id=\'plan-a-journey\']/div[1]/div[1]/div[2]/span[1]");

        public void ViewjourneyResults()
        {
            IWebElement journeyResultsLocator = _driver.FindElement(journeyResults);
        }

        public void EditJourneyLink()
        {
            _driver.FindElement(editJourneyLink).Click();
        }

        public void FillToField(string InputTo)
        {
            IWebElement toLocator = _driver.FindElement(toField);
            _driver.FindElement(toField).Clear();
            _driver.FindElement(toField).SendKeys(InputTo);
        }

        public void UpdateJourneyButton()
        {
            _driver.FindElement(updateJourneyButton).Click();
        }

        public void JourneyResult()
        {
            _driver.FindElement(journeyResults);
        }

        public void JourneyToLabel()
        {
            IWebElement toLabelLocator = _driver.FindElement(toLabel);

        }

        public string JourneyResultPage()
        {
            return _driver.FindElement(toLabel).Text.Trim();
        }
    }
}
