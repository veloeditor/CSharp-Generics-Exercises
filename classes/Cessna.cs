using System;

    namespace GenericsPractice {
        public class Cessna : Vehicle, IGasVehicle {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        

        public void RefuelTank () {}

         public override void Drive()
        {
            Console.WriteLine("The Cessna goes Vroom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna landed and turned {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna reached its parking spot and rolled to a stop.");
        }

        public void RefillGasTank()
        {
            Console.WriteLine("The Cessna has been full refueled.");
        }
    }
}