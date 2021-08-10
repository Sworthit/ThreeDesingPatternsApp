using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeDesingPatternsApp.Animals.Creators
{
    public class LionFactory : AnimalFactory
    {
        public override Animal CreateAnimal()
        {
            Console.WriteLine("Creating lion");
            return new Lion();
        }
    }
}
