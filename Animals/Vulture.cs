using System;
using System.Collections.Generic;
using System.Text;
using ThreeDesingPatternsApp.Animals.Observers;

namespace ThreeDesingPatternsApp.Animals
{
    public class Vulture : Animal
    {
        public void Eat(Zebra animal)
        {
            if (animal.IsAlive == true || animal.CarcassEaten == true)
            {
                Console.WriteLine($"Vulture tried to eat {animal.GetType().Name}, but was not able to");
            }
            else
            {
                Console.WriteLine($"Vulture ate {animal.GetType().Name}");
                animal.CarcassEaten = true;
            }
            Notify();
        }

        public override void Speak()
        {
            Console.WriteLine("Im a Vulture. (old western movie soundtrack)");
        }

        public override void Attach(IAnimalObserver animalObserver)
        {
            Console.WriteLine("Vulture: Attached an observer");
            _animalObservers.Add(animalObserver);
        }

        public override void Detach(IAnimalObserver animalObserver)
        {
            Console.WriteLine("Vulture: Detached an observer");
            _animalObservers.Remove(animalObserver);
        }

        public override void Notify()
        {
            Console.WriteLine("Vulture: Notyfing observers");

            foreach (var observer in _animalObservers)
            {
                observer.Update(this);
            }
        }
    }
}
