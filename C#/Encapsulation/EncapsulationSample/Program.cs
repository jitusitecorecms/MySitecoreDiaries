using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle ob = new Rectangle();
            double area = ob.CalculateArea(5.0, 6.2);
        }
    }
}
