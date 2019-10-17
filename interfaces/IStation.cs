using System;
using System.Collections.Generic;

namespace GenericsPractice {
    public interface IStation<T>
    {
        int Capacity {get; set;}
        void Refuel(List<T> vehicles);
    }
}