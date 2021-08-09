using System;
using System.Collections.Generic;
using System.Text;
using ThreeDesingPatternsApp.Animals.Classes;

namespace ThreeDesingPatternsApp.Animals.Observers
{
    public interface IAnimalObserver
    {
        void Update(IAnimal animal);
    }
}
