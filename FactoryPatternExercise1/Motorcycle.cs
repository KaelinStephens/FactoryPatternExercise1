using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("You chose Motorcycle.");
        }
        public int TireNumber { get; set; }
        public void Drive()
        {
            Console.WriteLine("To drive the Motorcycle you must first turn the key to the on position and press the start engine button while sitting astride the bike with your helmet on. " +
              "Next, press down on the clutch to get into first gear. " +
              "Use the throttle to increase your speed, breaks to decrease your speed, and clutch to change gears. " +
              "Use the handlebars to control the bike's direction.");
        }
    }
}
