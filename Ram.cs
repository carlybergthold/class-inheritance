using System;

namespace Inheritance
{
    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }

        // public void RefuelTank() { ... }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram goes vrooooooom!");
        }
        public override void Stop()
        {
            Console.WriteLine("Ladies and gentlemen, we have rammed until we can ram no more.");
        }
    }
}