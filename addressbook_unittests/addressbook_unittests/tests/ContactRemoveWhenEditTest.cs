using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class ContactRemoveWhenEditTest : TestBase
    {
        [Test]
        public void ContactRemovalWhenEdit()
        {
            appmanager.ContactH.RemoveFromModificationWindow();
        }
    }
}
