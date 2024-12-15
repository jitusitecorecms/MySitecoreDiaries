using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




    // Base class
    class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }
    }

    // Derived class hiding the MakeSound method of the base class
    class Dog : Animal
    {
        public new void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

   
