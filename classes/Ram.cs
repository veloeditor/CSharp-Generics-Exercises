using System;

namespace GenericsPractice {
        public class Ram : Vehicle, IGasVehicle {  // Gas powered truck
        public double FuelCapacity { get; set; }

        public void RefuelTank () {}

        

        public override void Drive()
        {
            Console.WriteLine("The Ram goes zoom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram reached the intersection and turned {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram reached the contruction site and hit the brakes.");
        }

        public void RefillGasTank()
        {
            Console.WriteLine("The Ram has been fully refueled.");
        }
    }
}