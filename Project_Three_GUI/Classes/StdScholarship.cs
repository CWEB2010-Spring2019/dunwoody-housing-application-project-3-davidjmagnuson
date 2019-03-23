using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Classes
{
    public class StdScholarship : Resident
    {
        public Double boardingFee { get; set; }

        public StdScholarship(string first, string last, int id, int room, int floor, double rent)
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
