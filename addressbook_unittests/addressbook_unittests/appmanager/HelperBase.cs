using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace addressbook_unittests
{
    public class HelperBase
    {
        protected IWebDriver driver;
        protected HelperBase (IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}