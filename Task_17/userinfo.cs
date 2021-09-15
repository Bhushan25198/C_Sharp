using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailID { get; set; }

        public UserInfo(string username, string passwd, string mailid)
        {
            UserName = username;
            Password = passwd;
            EmailID = mailid;
        }


    }
}
