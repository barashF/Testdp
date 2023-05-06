using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DoorPlugin2
{
    class ApplicationContxt : DbContext
    {
        public DbSet<Models.Main_inf_door> main_inf_doors { get; set; }

        public ApplicationContxt() : base("DefaultConnection") { }
    }
}
