using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel
{
    public class Users
    {
        Modules.File File = new Modules.File();
        
        public void CreateUser(string fullname, string nickname, string password)
        {
            if (UserExists(nickname))
            {
                return;
            }
            else
            {
                string user = $"{nickname}/{fullname}/{password}";

                File.WriteAllText("Configuration/USERS.CONFIG", user);
            }
        }

        public void CreateAdministrator()
        {
            if (UserExists("admin"))
            {
                return;
            }
            else
            {
                if (!File.Exists("Configuration/USERS.CONFIG"))
                {
                    string text = "admin/Administrator/admin";

                    File.WriteAllText("Configuration/USERS.CONFIG", text);
                }
            }
        }

        public List<User> ListUsers()
        {
            List<User> users = new List<User>();

            if (File.Exists("Configuration/USERS.CONFIG"))
            {
                string[] lines = File.ReadAllLines("Configuration/USERS.CONFIG");

                foreach(string line in lines)
                {
                    users.Add(new User(line.Split('/')[1], line.Split('/')[0], line.Split('/')[2]));
                }
            }

            return users;
        }

        private bool UserExists(string nickname)
        {
            if (File.Exists("Configuration/USERS.CONFIG"))
            {
                string[] lines = File.ReadAllLines("Configuration/USERS.CONFIG");

                foreach (string line in lines)
                {
                    if (line.Split('/')[0] == nickname)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return false;
            }
            else
            {
                return false;
            }
        }

    }
}
