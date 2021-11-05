using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace addressbook_unittests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigation;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";
            loginHelper = new LoginHelper(driver);
            navigation = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);
        }
        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        public LoginHelper LoginH
        {
            get
            {
                return loginHelper;
            }
        }
        public NavigationHelper NavigationH
        {
            get
            {
                return navigation;
            }
        }
        public GroupHelper GroupH
        {
            get
            {
                return groupHelper;
            }
        }
        public ContactHelper ContactH
        {
            get
            {
                return contactHelper;
            }
        }
    }
}
