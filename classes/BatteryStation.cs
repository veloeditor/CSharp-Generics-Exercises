using System;
using System.Collections.Generic;

namespace GenericsPractice {
    public class BatteryStation : IStation<IElectricVehicle>
    {
        //each station must have a capacity
        public int Capacity { get; set; }

        //create the batterystation which takes capacity as an argument
        public BatteryStation(int capacity) {
            Capacity = capacity;
        }

        //define constructor to refuel and make sure to check against the capacity of that station
        public void Refuel(List<IElectricVehicle> vehicles)
        {
            if (vehicles.Count <= Capacity) {
                foreach(IElectricVehicle vehicle in vehicles) {
                    vehicle.RechargeBattery();
                }
            } else {
                //console out a message telling the user that the station is full
                Console.WriteLine("----Electric Vehicle Charging Station Report----");
                Console.WriteLine($"Too many vehicles are trying to use this station. The station's capacity is {Capacity} vehicles at a time.");
                Console.WriteLine();
            }
        }
    }
}