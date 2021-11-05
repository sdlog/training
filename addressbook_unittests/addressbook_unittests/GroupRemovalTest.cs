using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class GroupRemovalTest : TestBase
    {
        [Test]
        public void GroupRemoval()
        {
            OpenTestPage();
            Login(new AccountData("admin", "secret"));
            OpenGroupsPage();
            SelectGroup();
            DeleteGroup();
            ReturnToGroupsPage();
        }
    }
}