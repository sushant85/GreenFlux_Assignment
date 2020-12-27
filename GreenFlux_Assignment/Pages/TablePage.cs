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
    class TablePage
    {
        public TablePage()
        {

            PageFactory.InitElements(Browser.Current, this);

        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/table[1]/tbody/tr[1]/td[1]")]
        public IWebElement LastName;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/table[1]/tbody/tr[1]/td[4]")]
        public IWebElement Due;


        public void LstnameDue()
        {
            string LName = LastName.Text;
            string DueAmount = Due.Text;
            Console.WriteLine("Lastname: " +  LName);
            Console.WriteLine("Due: " + DueAmount);

        }
    }
}