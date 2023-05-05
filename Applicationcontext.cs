using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace test_sqlite
{
    class Applicationcontext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public Applicationcontext() : base("DefaultConnection") { }
    }
    class Test
    {
        

        
    }
}
