using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeDesingPatternsApp.Animals.Creators
{
    public class ZebraFactory : AnimalFactory
    {
        public override Animal CreateAnimal()
        {
            Console.WriteLine("Creating zebra");
            return new Zebra();
        }
    }
}
