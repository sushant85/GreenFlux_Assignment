
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
    class DynamicControlSteps
    {

        IWebDriver currentDriver = null;

        ControlPage c = new ControlPage();

        [Given(@"I have navigated to Dynamic controls page")]
        public void GivenIHaveNavigatedToDynamicControlsPage()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["DynamicUrl"]);
            currentDriver = Browser.Current;
        }


        [When(@"I select checkbox and click on Remove button")]
        public void WhenISelectCheckboxAndClickOnRemoveButton()
        {
            c.ClickRemovebutton();
        }

       
            [Then(@"I should see it's gone message")]
            public void ThenIShouldSeeItSGoneMessage()
            {
                c.verifyGonetxt();
        }

        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {
            c.ClickAddbutton();
        }

        [Then(@"I should see it's back message")]
        public void ThenIShouldSeeItSBackMessage()
        {
            c.verifyBacktxt();
        }

        [Then(@"check textbox enable or disable")]
        public void ThenCheckTextboxEnableOrDisable()
        {
            c.Checktextbox();
        }

    }
}
