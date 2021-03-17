using System;

namespace Taxi_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat Object Taxi
            Taxi taxi = new Taxi();

            // Set Nilai Properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // Memanggil Method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
