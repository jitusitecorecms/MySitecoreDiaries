using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationSample
{
    public class Maths
    {
        public int Add(int a, int b)
        {
            return (a + b);
        }

        public int Add(int a, int b, int c)
        {
            return (a + b + c);
        }

        public double Add(double a, int b)
        {
            return (a + Convert.ToDouble(b));
        }

        public double Add(int b, double a)
        {
            return (a + Convert.ToDouble(b));
        }
    }


    //public class Shape
    //{
    //    public virtual double CalculateArea(){ return 0; }
    //}
    //public class Rectangle : Shape
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }
    //    public override double CalculateArea(){ return Width * Height;}
    //}
}
