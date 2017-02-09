using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of kilometers");
            float km = float.Parse(Console.ReadLine());

            float m = km * 1000;
         
            Console.WriteLine("{0} km = {1} m " , km, m);
            Console.WriteLine($"{km} km = {m} m");
            Console.WriteLine(km + " km =  " + m + " m" );
            Console.Write("Enter Pin:****\b\b\b\b");
            int pin = int.Parse(Console.ReadLine());
        
            
        }
    }
}
