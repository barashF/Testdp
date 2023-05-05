using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_sqlite
{
    class Class1
    {
        Applicationcontext db;

        public Main()
        {
            db = new Applicationcontext();

            db.Users.Find(1);
        }
    }
}
