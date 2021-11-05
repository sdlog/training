using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Runtime.Remoting.Messaging;

namespace addressbook_unittests
{
    public class TestBase
    {
        protected ApplicationManager appmanager;

        [SetUp]
        protected void SetupTest()
        {
            appmanager = new ApplicationManager();
        }

        [TearDown]
        protected void TeardownTest()
        {
            appmanager.Stop();
        }
    }
}
