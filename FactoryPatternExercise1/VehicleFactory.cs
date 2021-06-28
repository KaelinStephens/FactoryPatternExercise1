using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tires)
        {
            switch (tires)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new GoKart();
                default:
                    return new NoVehicle();
            }
        }
          
    }
}
