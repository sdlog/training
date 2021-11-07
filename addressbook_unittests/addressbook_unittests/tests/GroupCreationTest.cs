using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class GroupCreationTest : TestBase
    {
        [Test]
        public void GroupCreation()
        {
            GroupData newgroup = new GroupData("NewTestGroup1");
            newgroup.Header = "a";
            newgroup.Footer = "b";
            appmanager.GroupH.Create(newgroup);
        }
    }
}

