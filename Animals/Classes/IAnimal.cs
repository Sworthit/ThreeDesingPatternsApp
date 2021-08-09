using System;
using System.Collections.Generic;
using System.Text;
using ThreeDesingPatternsApp.Animals.Observers;

namespace ThreeDesingPatternsApp.Animals.Classes
{
    public interface IAnimal
    {
        void Attach(IAnimalObserver animalObserver);
        void Detach(IAnimalObserver animalObserver);
        void Notify();
    }
}
