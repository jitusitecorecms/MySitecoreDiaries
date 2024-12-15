using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationSample
{
    public class BankAccount
    {
        private double balance;
        public void Deposit(double amount)
        {
            // Perform necessary validation and update the balance
            balance += amount;
        }

        public double GetBalance()
        {
            // Only allow external access to the balance through a controlled method
            return balance;
        }


    }

    public class Area
    {
        private double _calculatedArea;
        public Area()
        {
            _calculatedArea = 0.0;
        }

        public Area(double length, double width)
        {
            _calculatedArea = length * width;
        }
    }




    public class Rectangle1
    {
        private double length;
        private double width;
        public Rectangle1()
        {
        }
        public Rectangle1(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculateArea(double length, double width)
        {
            return length * width;
        }
    }


    public class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Encapsulated property with validation
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new ArgumentException("Age must be greater than zero.");
            }
        }
    }


    public class TimePeriod
    {
        private double _seconds;
        public double Hours
        {
            get { return _seconds / 3600; }
            set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException(nameof(value),
                          "The valid range is between 0 and 24.");

                _seconds = value * 3600;
            }
        }
    }


}
