using System;
using System.Collections.Generic;
using System.Text;
using ThreeDesingPatternsApp.Animals.Classes;

namespace ThreeDesingPatternsApp.Animals.Observers
{
    public class LionObserver : IAnimalObserver
    {
        public Lion MainLionToObserve { get; set; }
        public void Update(IAnimal animal)
        {
            if (animal is Zebra)
            {
                MainLionToObserve.Eat((Zebra)animal);
            }
        }
    }
}
