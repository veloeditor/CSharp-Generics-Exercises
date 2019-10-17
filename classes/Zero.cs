using System;

namespace GenericsPractice {
    public class Zero : Vehicle, IElectricVehicle {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery () {}

        public override void Drive()
        {
            Console.WriteLine("The Zero goes vrooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero reached the intersection and turned {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero reached its parking spot and rolled to a stop.");
        }

        public void RechargeBattery()
        {
            Console.WriteLine("The Zero's battery is fully recharged.");
        }
    }
}