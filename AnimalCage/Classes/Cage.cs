using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AnimalCage.Classes
{
    class Cage <T>
    {
        List<T> listOfAnimals = new List<T>();

        public void AddAnimal(T animal)
        {
            listOfAnimals.Add(animal);
        }

        public void RemoveAnimal(T animal)
        {
            listOfAnimals.RemoveAt(listOfAnimals.Count-1);
        }

        public override string ToString()
        {
            string str = "";

            foreach (var animal in listOfAnimals)
            {
                str += animal.ToString();
            }

            return str;
        }
    }
}
