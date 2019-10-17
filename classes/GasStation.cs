using System;
using System.Collections.Generic;

namespace GenericsPractice {
    public class GasStation : IStation<IGasVehicle>
    {
        //each station must have a capacity
        public int Capacity { get; set; }

        //create the gas station which takes capacity as an argument
        public GasStation(int capacity) {
            Capacity = capacity;
        }

        //define constructor to refuel and make sure to check against the capacity of that station
        public void Refuel(List<IGasVehicle> vehicles)
        {
            if (vehicles.Count <= Capacity) {
                foreach(IGasVehicle vehicle in vehicles) {
                    vehicle.RefillGasTank();
                }
            } else {
                //console out a message telling the user that the station is full
                Console.WriteLine($"Too many vehicles are trying to use this station. The station's capacity is {Capacity} vehicles at a time.");
            }
        }
    }
}