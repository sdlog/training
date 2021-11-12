using NUnit.Framework;

namespace addressbook_unittests
{
    [TestFixture]
    public class GroupModificationTest : TestBase
    {
        [Test]
        public void GroupModification()
        {
            GroupData newdata = new GroupData("ModifiedTestGroup1");
            newdata.Header = "x";
            newdata.Footer = "y";
            appmanager.GroupH.Modify(1, newdata);
        }  
    }
}
