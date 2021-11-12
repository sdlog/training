using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace addressbook_unittests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager):base(manager)
        {
        }
        public ContactHelper Create(ContactData contact)
        {
            manager.NavigationH.AddNewLink();
            FillContactForm(contact);
            SubmitContactCreation();
            manager.NavigationH.OpenHomePage();
            return this;
        }
        public ContactHelper RemoveFromContactList()
        {
            SelectContact();
            DeleteContact();
            SubmitContactRemoving();
            return this;
        }
        public ContactHelper RemoveFromModificationWindow()
        {
            SelectContact();
            ModifyContact();
            DeleteContact();
            return this;
        }
        public ContactHelper Modify(ContactData contact)
        {
            SelectContact();
            ModifyContact();
            FillContactForm(contact);
            SubmitContactModification();
            manager.NavigationH.OpenHomePage();
            return this;
        }
        public ContactHelper FillContactForm(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            driver.FindElement(By.Name("home")).Click();
            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys(contact.Home);
            driver.FindElement(By.Name("mobile")).Click();
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys(contact.Mobile);
            driver.FindElement(By.Name("work")).Click();
            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("work")).SendKeys(contact.Work);
            return this;
        }
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;
        }
        public ContactHelper SubmitContactRemoving()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }
        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }
        public ContactHelper SelectContact()
        {
            driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();
            return this;
        }
        public ContactHelper DeleteContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }
        public ContactHelper ModifyContact()
        {
            driver.FindElement(By.XPath(".//*[@title='Edit']")).Click();
            return this;
        }
    }
}
