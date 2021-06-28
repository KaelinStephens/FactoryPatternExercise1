using System;

namespace FactoryPatternExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have?");
            int input = int.Parse(Console.ReadLine());
            var chosen = VehicleFactory.GetVehicle(input);
            Console.WriteLine("************************************");
            Console.WriteLine($"Here is how you drive your chosen vehicle:");
            chosen.Drive();
        }
    }
}
