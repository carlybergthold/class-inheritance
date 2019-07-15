using System;

namespace Inheritance
{
    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }

        // public void RefuelTank() { ... }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes Zoooooom!");
        }
        public override void Turn()
        {
            Console.WriteLine($"Is it left? Is it right? Who cares, this {this.GetType().Name} be soaring in another direction");
        }
    }
}