using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class GroupCreation : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            appmanager.NavigationH.OpenTestPage();
            appmanager.LoginH.Login(new AccountData("admin", "secret"));
            appmanager.NavigationH.OpenGroupsPage();
            appmanager.GroupH.StartNewGroupCreation();
            GroupData newgroup = new GroupData("NewTestGroup1");
            newgroup.Header = "a";
            newgroup.Footer = "b";
            appmanager.GroupH.FillGroupForm(newgroup);
            appmanager.GroupH.SubmitGroupCreation();
            appmanager.NavigationH.ReturnToGroupsPage();
            appmanager.LoginH.Logout();
        }
    }
}

