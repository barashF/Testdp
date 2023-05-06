using System;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

namespace DoorPlugin2.Models
{
    public class Main_inf_door
    {
        public string id, address, owner;

        public int sell;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Owner
        {
            get { return id; }
            set { id = value; }
        }

        public Main_inf_door() { }

        public Main_inf_door(string id, string address, string owner, int sell)
        {
            this.id = id;
            this.address = address;
            this.owner = owner;
            this.sell = sell;
        }
    }
}
