using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDanObject
{
    internal class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", this.DriverName);
            Console.WriteLine("On Duty: {0}", this.OnDuty ? "Yes" : "No");
            Console.WriteLine("Number of Passenger: {0}", this.NumPassenger);
            Console.WriteLine();
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("Jono sedang menjemput penumpang");
        }
        public void DropOffPasengger()
        {
            Console.WriteLine("Jono sedang mengantar penumpang");
        }
    }
}
