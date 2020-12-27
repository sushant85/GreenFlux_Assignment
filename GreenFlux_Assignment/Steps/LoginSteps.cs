using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using GreenFlux_Assignment.Pages;

namespace GreenFlux_Assignment.Steps
{
    [Binding]
    class LoginSteps
    {

        IWebDriver currentDriver = null;

        LoginPages page = new LoginPages();

        [Given(@"I have navigated to login page")]
        public void GivenIHaveNavigatedToLoginPage()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["LoginUrl"]);
            currentDriver = Browser.Current;

        }


        [Then(@"I typed the (.*) and (.*)")]
        public void ThenITypedTheAnd(string username, string password)
        {
            page.login(username, password);
        }

        [Then(@"click on login button")]
        public void ThenClickOnLoginButton()
        {

            page.clicklogin();
        }

      

    }
}





