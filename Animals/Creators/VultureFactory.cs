using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeDesingPatternsApp.Animals.Creators
{
    public class VultureFactory : AnimalFactory
    {
        public override Animal CreateAnimal()
        {
            Console.WriteLine("Creating vulture");
            return new Vulture();
        }
    }
}
