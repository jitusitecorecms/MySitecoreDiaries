using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationSample
{

    // Define an interface
    public interface IShape
    {
        double CalculateArea();
    }



    // Implement the interface in a class
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }



    // Define interfaces
   

    // Define interfaces
    public interface IAnimal
    {
        void Eat();
    }

    public interface IMammal : IAnimal
    {
        void Nurse();
    }

    public interface IDog : IMammal
    {
        void Bark();
    }

    // Implement interfaces in classes
    public class Dog : IDog
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }

        public void Nurse()
        {
            Console.WriteLine("Dog is nursing.");
        }
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    public class Bat : IAnimal, IMammal
    {
        public void Eat()
        {
            Console.WriteLine("Bat is eating.");
        }

        public void Nurse()
        {
            Console.WriteLine("Bat is nursing.");
        }
    }



}
