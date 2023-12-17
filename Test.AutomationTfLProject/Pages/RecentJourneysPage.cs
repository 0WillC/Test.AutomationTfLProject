using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AutomationTfLProject.Pages
{
    public class RecentsJourneysPage
    {
        private IWebDriver _driver;

        public RecentsJourneysPage(IWebDriver driver)
        {
            _driver = driver;
        }
        
        private By recentsTab = By.XPath("//*[@id='jp-recent-tab-home']/a");
        private By recentContent = By.Id("jp-recent-content-home-");
        private By acceptAllCookiesButtton = By.Id("CybotCookiebotDialogBodyLevelButton");

        public void AcceptAllCookies()
        {
            _driver.FindElement(acceptAllCookiesButtton).Click();
        }
       
        public void RecentsTab()
        {
            _driver.FindElement(recentsTab).Click();
        }

        public void ClickOnRecentContent()
        {
            _driver.FindElement(recentContent).Click();
        }

        public string RecentsContentHomePage()
        {
            return _driver.FindElement(recentContent).Text.Trim();
        }

    }

}