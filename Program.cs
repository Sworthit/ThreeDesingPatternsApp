using System;
using System.Collections.Generic;
using ThreeDesingPatternsApp.Animals;
using ThreeDesingPatternsApp.Animals.Creators;
using ThreeDesingPatternsApp.Animals.Observers;

namespace ThreeDesingPatternsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            var lionObserver = new LionObserver();
            var vultureObserver = new VultureObserver();
            var zebraObserver = new ZebraObserver();
            PopulateAnimalsWithFactory(animals);
            AttachObserversToList(animals, lionObserver, vultureObserver, zebraObserver);
            foreach (var animal in animals)
            {
                if (animal is Zebra)
                {
                    animal.Eat();
                }
            }
        }


        private static void AttachObserversToList(List<Animal> animals, LionObserver lionObserver, VultureObserver vultureObserver, ZebraObserver zebraObserver)
        {
            foreach (var animal in animals)
            {
                animal.Attach(zebraObserver);
                animal.Attach(lionObserver);
                animal.Attach(vultureObserver);
                if (animal is Lion)
                {
                    lionObserver.MainLionToObserve = (Lion)animal;
                }
                if (animal is Vulture)
                {
                    vultureObserver.MainVultureToObserve = (Vulture)animal;
                }
                if (animal is Zebra)
                {
                    zebraObserver.ZebraToObserve = (Zebra)animal;
                }
            }
        }

        private static void PopulateAnimalsWithFactory(List<Animal> animals)
        {
            AnimalFactory animalCreator = new LionFactory();
            animals.Add(animalCreator.CreateAnimal());
            animalCreator = new ZebraFactory();
            animals.Add(animalCreator.CreateAnimal());
            animalCreator = new VultureFactory();
            animals.Add(animalCreator.CreateAnimal());
        }
    }
}
