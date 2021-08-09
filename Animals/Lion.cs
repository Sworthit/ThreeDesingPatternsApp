using System;
using System.Collections.Generic;
using System.Text;
using ThreeDesingPatternsApp.Animals.Classes;
using ThreeDesingPatternsApp.Animals.Observers;

namespace ThreeDesingPatternsApp.Animals
{
    public class Lion : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Im a lion. Roar!");
        }

        public void Eat(Zebra zebra)
        {
            if (zebra.IsAlive == false)
            {
                Console.WriteLine("Lion didn't like dead zebra");
                return;
            }
            else
            {
                Console.WriteLine($"Lion ate zebra.");
                zebra.Die();
            }
            Notify();
        }


        public void FindZebra(List<Animal> animals)
        {
            foreach(var animal in animals)
            {
                if (animal is Zebra)
                {
                    Eat((Zebra)animal);
                    return;
                }
            }
        }

        public override void Attach(IAnimalObserver animalObserver)
        {
            Console.WriteLine("Lion: Attached an observer");
            _animalObservers.Add(animalObserver);
        }

        public override void Detach(IAnimalObserver animalObserver)
        {
            Console.WriteLine("Lion: Detached an observer");
            _animalObservers.Remove(animalObserver);
        }

        public override void Notify()
        {
            Console.WriteLine("Lion: Notyfing observers");

            foreach (var observer in _animalObservers)
            {
                observer.Update(this);
            }
        }
    }
}
