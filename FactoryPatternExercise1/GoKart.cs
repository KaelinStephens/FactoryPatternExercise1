using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public class GoKart : IVehicle 
    {
        public GoKart()
        {
            Console.WriteLine("You chose GoKart.");
        }
        public int TireNumber { get; set; }
        public void Drive()
        {
            Console.WriteLine("To drive the GoKart you must first pull the ripcord until the engine starts. " +
                "Next, sit in the driver's seat and strap in. " +
                "Use the gas and brake pedals to adjust your speed. " +
                "Use the steering wheel to control the kart's direction.");
        }
    }
}
