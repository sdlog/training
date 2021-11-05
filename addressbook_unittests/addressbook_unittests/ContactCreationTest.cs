using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class ContactCreation : TestBase
    {
        public void ContactCreationTest()
        {
            OpenTestPage();
            Login(new AccountData("admin", "secret"));
            AddNewLink();
            ContactData newcontact = new ContactData("fn","ln","1");
            newcontact.Home = "2";
            newcontact.Work = "3";
            FillContactForm(newcontact);
            SubmitContactCreation();
            OpenHomePage();
        }
    }
}
