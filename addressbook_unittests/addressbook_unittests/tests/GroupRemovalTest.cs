using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class GroupRemovalTest : TestBase
    {
        [Test]
        public void GroupRemoval()
        {
            appmanager.NavigationH.OpenTestPage();
            appmanager.LoginH.Login(new AccountData("admin", "secret"));
            appmanager.NavigationH.OpenGroupsPage();
            appmanager.GroupH.SelectGroup();
            appmanager.GroupH.DeleteGroup();
            appmanager.NavigationH.ReturnToGroupsPage();
        }
    }
}