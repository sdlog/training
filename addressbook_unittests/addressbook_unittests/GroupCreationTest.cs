using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class GroupCreation : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            OpenTestPage();
            Login(new AccountData("admin", "secret"));
            OpenGroupsPage();
            StartNewGroupCreation();
            GroupData newgroup = new GroupData("NewTestGroup1");
            newgroup.Header = "a";
            newgroup.Footer = "b";
            FillGroupForm(newgroup);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            Logout();
        }
    }
}

