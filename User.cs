using System;
using System.Data.SQLite;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;

namespace test_sqlite
{
    public class User
    {
        private int id { get; set; }

        private string login, pass, email;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public User() { }
        public User(string login, string pass, string email) 
        {
            this.login = login;
            this.email = email;
            this.pass = pass;
        }


}
    
}
