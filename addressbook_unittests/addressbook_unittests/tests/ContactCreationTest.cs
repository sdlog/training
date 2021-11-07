using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class ContactCreationTest : TestBase
    {
        [Test]
        public void ContactCreation()
        {
            ContactData newcontact = new ContactData("fn", "ln", "1");
            newcontact.Home = "2";
            newcontact.Work = "3";
            appmanager.ContactH.Create(newcontact);
        }
    }
}
