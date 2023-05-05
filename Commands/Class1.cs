using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorPlugin
{
    class Class1
    {
        Models.Main_inf_door door1 = new Models.Main_inf_door("a", "b", "c", 1);
        ApplicationContxt db = new ApplicationContxt();

        db.main_inf_doors.Add(door1);
    }
}
