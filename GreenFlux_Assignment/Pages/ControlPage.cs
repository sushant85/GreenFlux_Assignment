using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFlux_Assignment.Pages
{
    class ControlPage
    {
        public ControlPage()
        {

            PageFactory.InitElements(Browser.Current, this);
        }


        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/form[1]/button")]
        public IWebElement RemoveAdd;

        [FindsBy(How = How.XPath, Using = "//*[@id='checkbox']")]
        public IWebElement box;

        [FindsBy(How = How.XPath, Using = "//*[@id='message']")]
        public IWebElement txt;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/form[2]/input")]
        public IWebElement txtbox;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/form[2]/button")]
        public IWebElement enablebox;
        

        string txtverify1 = "It's gone!";
        string txtverify2 = "It's back!";


        public void ClickRemovebutton()
        {
            Assert.IsTrue(box.Selected);
            RemoveAdd.Submit();



        }

        public void verifyGonetxt()
        {
            try
            {
                Assert.IsTrue(txt.Text.Contains(txtverify1));
                Console.WriteLine("assertion pass");
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }



        public void ClickAddbutton()
        {
            
            RemoveAdd.Submit();
        }

        public void verifyBacktxt()
        {
            try
            {
                Assert.IsTrue(txt.Text.Contains(txtverify2));
                Console.WriteLine("assertion pass");
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }

        public void Checktextbox()
        {
            if (!txtbox.Enabled)

            {
                enablebox.Submit();
            }
            else
            {
                txtbox.Click();

            }
        }

    }

}



