using System;
using System.Collections.Generic;

namespace GenericsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of various vehicles
            Cessna citation = new Cessna();
            Ram ram1 = new Ram();
            Ram ram2 = new Ram();
            Tesla modelX = new Tesla();
            Tesla model2 = new Tesla();
            Zero zero1 = new Zero();
            Zero zero2 = new Zero();
            Cessna proppy1 = new Cessna();

            // In your main method, make sure you have a list of electric vehicles, and a list of gas vehicles.
            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                modelX, zero1, zero2
            };

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram1, citation, proppy1, ram2,
            };
            
            // Create an instance of BatteryStation and GasStation.
            BatteryStation batteryStation = new BatteryStation(3);
            GasStation gasStation = new GasStation(4);

            // Refuel all the vehicles by sending them to the correct refueling station.
            batteryStation.Refuel(electricVehicles);
            Console.WriteLine();
            gasStation.Refuel(gasVehicles);
            Console.WriteLine();

        }
    }
}
