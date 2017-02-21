using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_arbait__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of colums and lines your squad matrix");
            int num = int.Parse(Console.ReadLine());
            int[,] mat1 = new int[num, num];
            Random rand = new Random();
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    int p = rand.Next(20);
                    if (p % 3 == 0)
                    {
                        mat1[i, j] = p;
                    }
                    else if (p % 3 != 0)
                    {
                        mat1[i, j] = 3; 
                    }
                    Console.Write("{0}\t", mat1[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
