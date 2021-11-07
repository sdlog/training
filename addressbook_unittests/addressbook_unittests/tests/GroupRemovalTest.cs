using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class GroupRemovalTest : TestBase
    {
        [Test]
        public void GroupRemoval()
        {
            appmanager.GroupH.Remove(1);
        }
    }
}