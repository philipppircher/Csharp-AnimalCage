using AnimalCage.Classes;
using System;

namespace AnimalCage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tigerCage and tiger instances
            //
            Cage<Tiger> tigerCage = new Cage<Tiger>();
            Tiger tiger1 = new Tiger("tiger1\n");
            Tiger tiger2 = new Tiger("tiger2\n");

            // Add tiger to tigerCage
            //
            tigerCage.AddAnimal(tiger1);
            tigerCage.AddAnimal(tiger2);

            // Print all tigers in tigerCage
            //
            Console.WriteLine(tigerCage.ToString());

            // Create a monkeyCage and monkey instances
            //
            Cage<Monkey> monkeyCage = new Cage<Monkey>();
            Monkey monkey1 = new Monkey("monkey1\n");
            Monkey monkey2 = new Monkey("monkey2\n");

            // Add monkey to monkeyCage
            //
            monkeyCage.AddAnimal(monkey1);
            monkeyCage.AddAnimal(monkey2);

            // Print all monkey ins MonkeyCage
            //
            Console.WriteLine(monkeyCage.ToString());

            // Try to add monkey to tigerCage (cause erreor)
            //
            // tigerCage.AddAnimal(monkey1);

            // monkeyCage.AddAnimal(tiger1);
        }
    }
}
