using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle Calculator");
            Console.WriteLine("Enter radius");
          double r = double.Parse(Console.ReadLine());
            double c;
            double pi = Math.PI;

            c =  2 * pi * r;

            Console.WriteLine("R=" + r);
            Console.WriteLine("C= {0}", c );
        }
    }
}
