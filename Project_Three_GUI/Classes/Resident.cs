using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI
{
    public class Resident
    {
        public string first { get; set; }
        public string last { get; set; }
        public int id { get; set; }
        public int room { get; set; }
        public int floor { get; set; }
        public double rent { get; set; }

        public Resident(string first, string last, int id, int room, int floor, double rent)
        {
            this.first = first;
            this.last = last;
            this.id = id;
            this.room = room;
            this.floor = floor;
            this.rent = rent;
        }
    }
}
