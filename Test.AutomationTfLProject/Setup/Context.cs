using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test.AutomationTfLProject.Setup
{
    public class Context
    {
        private IWebDriver _driver;
        private IObjectContainer _objectContainer;
        string baseUrl = "https://tfl.gov.uk";

        public Context(IObjectContainer objectContainer)
        
        {
            _objectContainer = objectContainer;

           
        }
         public void loadApplicationUnderTest()       
        {
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            _driver.Navigate().GoToUrl(baseUrl);
          
        }

         public void ShutDownApplicationUnderTest()
        
        {
            _driver?.Quit();
           
        }
    }
}

