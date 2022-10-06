using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OF_stock_managment
{
    class User
    {
        string name;
        string username;
        string pwd;
        UserDBLayer u;

        public User() { }
        public User(string firstName, string lastName,string username,string pwd)
        {
            name = firstName + " " + lastName;
            this.username = username;
            this.pwd = pwd;
        }

        public string checkUser(string username,string pwd)
        {
            
            u = new UserDBLayer();
            return u.checkUserDBLayer(username, pwd);

        }

    }
}
