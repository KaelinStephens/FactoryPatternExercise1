using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public class NoVehicle : IVehicle
    {
        public NoVehicle()
        {
            Console.WriteLine("Invalid entry");
        }
        public int TireNumber { get; set; }
        public void Drive()
        {
            Console.WriteLine("I guess you're walking");
        }
    }
}
