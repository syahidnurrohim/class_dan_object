using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDanObject
{
    class Program
    {
        public static void Main()
        {
            Taxi taxi = new Taxi();
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPasengger();

            Console.ReadKey();
        }
    }
}
