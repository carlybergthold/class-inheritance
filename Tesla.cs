using System;

namespace Inheritance
{
    public class Tesla : Vehicle
    {  // Electric car
        public double BatteryKWh { get; set; }

        // public void ChargeBattery() { ... }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla goes shhhhhhh!");
        }
        public override void Stop()
        {
            Console.WriteLine("Ladies and gentlemen, Elon has commanded we cease.");
        }
    }
}