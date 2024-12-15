using System;
// Base class
class Animal1
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("The animal is sleeping.");
    }
}

// Derived class (inherits from Animal)
class Dog1 : Animal1
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the derived class
        Dog myDog = new Dog();

        // Access methods from the base class
        myDog.Eat();
        myDog.Sleep();

        // Access method from the derived class
        myDog.Bark();
    }
}
