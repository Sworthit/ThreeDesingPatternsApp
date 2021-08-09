using System;
using System.Collections.Generic;
using System.Text;
using ThreeDesingPatternsApp.Animals.Classes;
using ThreeDesingPatternsApp.Animals.Observers;

namespace ThreeDesingPatternsApp
{
    public abstract class Animal : IAnimal
    {
        protected List<IAnimalObserver> _animalObservers = new List<IAnimalObserver>();
        public bool IsAlive { get; set; } = true;
        public virtual void Eat() { }
        public void Die()
        {
            IsAlive = false;
        }
        public abstract void Speak();

        public virtual void Attach(IAnimalObserver animalObserver) { }

        public virtual void Detach(IAnimalObserver animalObserver) { }

        public virtual void Notify() { }
    }
}
