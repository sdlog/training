using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_unittests
{
    class AccountData
    {
        private string accountname;
        private string password;

        public AccountData(string accountname, string password)
        {
            this.accountname = accountname;
            this.password = password;
        }

        public string AccountName
        {
            get
            {
                return accountname;
            }
            set 
            {
                accountname = value;
            }

        }
        public string Password
        {
            get 
            {
                return password;
            }
            set 
            {
                password = value;
            }
        }
    }
}
