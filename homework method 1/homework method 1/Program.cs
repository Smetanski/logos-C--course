using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_method_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 0 to 10 ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ElNumbers(n));
            Console.ReadKey();
        }
        static int ElNumbers(int n)
        {

            int[] ar = new int[10];
            Random r = new Random();
            Console.WriteLine("This is random array ");
            for (int i = 0; i < 10; i++)
            {
                ar[i] = r.Next(1,10);
                
                Console.WriteLine("{0}\t", ar[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (ar[i] == n)
                {
                    Console.WriteLine("This is position of your number in array ");
                    return i;
                }
            }
            Console.WriteLine("Your number did't exist in array");
            return -1;
            return n;
        }
        
       
    }
}
 