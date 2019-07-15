using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var cessna = new Cessna() {
                MainColor = "white",
                MaximumOccupancy = 5,
                FuelCapacity = 2.3
            };
            var ram = new Ram() {
                MainColor = "blue",
                MaximumOccupancy = 6,
                FuelCapacity = 5.4
            };
            var tesla = new Tesla() {
                MainColor = "black",
                MaximumOccupancy = 5,
                BatteryKWh = 2.3
            };
            var zero = new Zero() {
                MainColor = "silver",
                MaximumOccupancy = 2,
                BatteryKWh = 4.3
            };

            cessna.Drive();
            cessna.Turn();
            cessna.Stop();
            ram.Drive();
            ram.Turn();
            ram.Stop();
            tesla.Drive();
            tesla.Turn();
            tesla.Stop();
            zero.Drive();
            zero.Turn();
            zero.Stop();

        }
    }
}
