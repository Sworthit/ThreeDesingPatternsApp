using System;
using System.Collections.Generic;
using System.Text;
using ThreeDesingPatternsApp.Animals.Observers;

namespace ThreeDesingPatternsApp.Animals
{
    public class Zebra : Animal
    {
        public bool CarcassEaten { get; set; } = false;
        public override void Eat()
        {
            Console.WriteLine("Zebra ate grass");
            Notify();
        }

        public override void Speak()
        {
            Console.WriteLine("Im a zebra. Iaaaah");
        }

        public override void Attach(IAnimalObserver animalObserver)
        {
            Console.WriteLine("Zebra: Attached an observer");
            _animalObservers.Add(animalObserver);
        }

        public override void Detach(IAnimalObserver animalObserver)
        {
            Console.WriteLine("Zebra: Detached an observer");
            _animalObservers.Remove(animalObserver);
        }

        public override void Notify()
        {
            foreach (var observer in _animalObservers)
            {
                observer.Update(this);
            }
        }

        public void CompletlyEatenZebra()
        {
            CarcassEaten = true;
            Console.WriteLine("Zebra carcass was eaten. There's nothing left of her");
        }

    }
}
