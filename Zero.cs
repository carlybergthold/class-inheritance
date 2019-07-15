using System;

namespace Inheritance
{
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        // public void ChargeBattery() { ... }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero goes errrrRRRRRrrrrrrRRRR!");
        }
        public override void Turn()
        {
            Console.WriteLine($"Is it left? Is it right? Who cares, this {this.GetType().Name} popped a turn wheelie");
        }
    }
}