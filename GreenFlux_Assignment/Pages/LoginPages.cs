using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFlux_Assignment.Pages
{
    class LoginPages
    {
        public LoginPages()
        {

            PageFactory.InitElements(Browser.Current, this);
        }
        [FindsBy(How = How.Name, Using = "Username")]
        public IWebElement txtUsername;

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword;

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin;


        public void login(string username, string password)
        {
            txtUsername.SendKeys(username);
            txtPassword.SendKeys(password);

        }

        public void clicklogin()
        {
            btnLogin.Submit();

        }
    }
}




