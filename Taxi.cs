using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_03
{
    class Taxi
    {
        // Properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: " + DriverName);
            Console.Write("On Duty: ");
            switch (OnDuty)
            {
                case true:
                    Console.WriteLine("Yes");
                    break;
                default:
                    Console.WriteLine("No");
                    break;
            }
            Console.WriteLine("Number of Passenger: " + NumPassenger + "\n");
        }
        public void PickUpPassenger()
        {
            Console.WriteLine(DriverName + " sedang menjemput penumpang");
        }
        public void DropOffPassenger()
        {
            Console.WriteLine(DriverName + " selesai mengantar penumpang");
        }
    }
}
