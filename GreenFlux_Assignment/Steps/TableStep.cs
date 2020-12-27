using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using GreenFlux_Assignment.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GreenFlux_Assignment.Steps
{
    [Binding]
    class TableStep
    {

        IWebDriver currentDriver = null;

        TablePage T = new TablePage();

        [Given(@"I have navigated to Data Table web page")]
        public void GivenIHaveNavigatedToDataTableWebPage()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["TableUrl"]);
            currentDriver = Browser.Current;
        }

        [Then(@"I want to fetch lastname and Due from Table")]
        public void ThenIWantToFetchLastnameAndDueFromTable()
        {
            T.LstnameDue();
        }

    }


}

