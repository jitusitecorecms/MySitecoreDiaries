using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationSample1
{
    using System;
    // Base class
    class Animal
    {
        protected string sound;
        public Animal(string sound){ this.sound = sound;}
        public virtual void MakeSound()
        {
            Console.WriteLine(sound);
        }
    }
    // Derived class
    class Dog : Animal
    {
        public Dog(string sound) : base(sound){}
        // This method overrides the MakeSound method in the base class
        public override void MakeSound()
        {
            base.MakeSound(); // Call the MakeSound method of the base class
            Console.WriteLine("A dog barks.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Woof!");
            myDog.MakeSound();
        }
    }

}
