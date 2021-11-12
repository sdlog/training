using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class ContactModificationTest : TestBase
    {
        [Test]
        public void ContactModification()
        {
            ContactData newdata = new ContactData("fn_modified2", "ln_modified3", "12345");
            appmanager.ContactH.Modify(newdata);
        }
    }
}
