using System;
using System.Collections.Generic;
using System.Text;
using ThreeDesingPatternsApp.Animals.Classes;

namespace ThreeDesingPatternsApp.Animals.Observers
{
    public class ZebraObserver : IAnimalObserver
    {
        public Zebra ZebraToObserve { get; set; }
        public void Update(IAnimal animal)
        {
        }
    }
}
