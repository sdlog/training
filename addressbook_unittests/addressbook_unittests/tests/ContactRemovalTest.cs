using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class ContactRemovalTest : TestBase
    {
        [Test]
        public void ContactRemoval()
        {
            appmanager.ContactH.RemoveFromContactList();
        }
    }
}
