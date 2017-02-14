using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_5_практика
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести число ");
            int a = int.Parse(Console.ReadLine());
            if ((a >= -5) && (a <= 17))
            {
                Console.WriteLine(" Входить у межі ");
            }
            else
            {
                Console.WriteLine(" Не входить в межі ");
                
            }

            /*Console.WriteLine("enter X ");
            int x = int.Parse(Console.ReadLine());
            if (  x > 150 )
            {
                Console.WriteLine("Y=" + (x * x + 127 / 5.5));
            }
            if (x == 0) { Console.WriteLine("Y=1996"); }
            if (x < -170) { Console.WriteLine("Y=" + (x / 100 + 127 * 3.14)); } */
        }
    }
}
