using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace addressbook_unittests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;
        public NavigationHelper (ApplicationManager manager, string baseURL):base(manager)
        {
            this.baseURL = baseURL;
        }
        public void OpenTestPage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        public void OpenGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void AddNewLink()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        public void OpenHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
        }
    }
}
