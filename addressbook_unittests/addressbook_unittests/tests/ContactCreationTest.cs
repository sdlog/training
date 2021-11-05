using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class ContactCreation : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            appmanager.NavigationH.OpenTestPage();
            appmanager.LoginH.Login(new AccountData("admin", "secret"));
            appmanager.NavigationH.AddNewLink();
            ContactData newcontact = new ContactData("fn", "ln", "1");
            newcontact.Home = "2";
            newcontact.Work = "3";
            appmanager.ContactH.FillContactForm(newcontact);
            appmanager.ContactH.SubmitContactCreation();
            appmanager.NavigationH.OpenHomePage();
        }
    }
}
