using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {

            /* int[] mas2 = { 0, 1, 2, 3, 4 };
             Console.WriteLine(mas2[2]);
             string[] mas3 = new string[10];
             mas3[0]= "Hello";
             mas3[1] = "youuuuu";
             Console.WriteLine(mas3[0] + mas3[1]);
            // ФОРМА ЗАПИСУ для "for"  -  for (int i = 0; i < 10; i++) ;
            */
            int[] mas1 = new int[3];
            /*Console.WriteLine("Enter #1");
            mas1[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter #2");
            mas1[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter #3");
            mas1[2] = int.Parse(Console.ReadLine());*/
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number");
                mas1[i] = int.Parse(Console.ReadLine());
                sum = +mas1[i];
                // sum = sum +mas1[i];
            }
            Console.WriteLine($"mas1[1] + mas1[2]");
        }
    }
}
