using System;
using System.Collections.Generic;
using System.Text;
using ThreeDesingPatternsApp.Animals.Classes;

namespace ThreeDesingPatternsApp.Animals.Observers
{
    public class VultureObserver : IAnimalObserver
    {
        public Vulture MainVultureToObserve { get; set; }
        public void Update(IAnimal animal)
        {
            if (animal is Zebra)
            {
                MainVultureToObserve.Eat((Zebra)animal);
            }
        }
    }
}
