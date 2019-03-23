using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Classes
{
    public class StdWorker : Resident
    {
        public Double hrsWorked { get; set; }
        public Double baseRate { get; set; }



        public Double WorkerPay(Double hours)
        {
            double pay = hours * baseRate;
            return pay;
        }
    }
}
