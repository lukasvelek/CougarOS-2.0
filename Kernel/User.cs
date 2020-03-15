using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel
{
    public class User
    {
        Modules.File File = new Modules.File();

        string fullname = "";
        string nickname = "";
        string password = "";

        public string Fullname { get => fullname; }
        public string Nickname { get => nickname; }
        public string Password { get => password; }

        public User(string fullname, string nickname, string password)
        {
            this.fullname = fullname;
            this.nickname = nickname;
            this.password = password;
        }

    }
}
