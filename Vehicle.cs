using System;

namespace Inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn()
        {
            Console.WriteLine($"Is it left? Is it right? Who cares, this {this.GetType().Name} turnt");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Ladies and gentlemen, we have come to a full stop.");
        }
    }
}