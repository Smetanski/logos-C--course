using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework___array_10_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of martrixs");
            Console.WriteLine("Enter number of colums ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of lines");
            int l = int.Parse(Console.ReadLine());

            // Random rand = new Random();
            float n = c * l;
            float p = (100/n); // залежить від кількості елементів у матриці => 100/n
            float s = 0;
            
            Console.WriteLine("Firs matrix");
            int[,] ar1 = new int[c, l];
            for ( int i = 0; i < c; i++)
            {
                for ( int j = 0; j < l; j++)
                {
                    // ar1[i, j] = rand.Next(10);
                    Console.WriteLine(" Enter [{0},{1}] elements", i, j);
                    ar1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Second matrix");
            int[,] ar2 = new int[c, l];
            
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    //ar2[i, j] = rand.Next(10);
                    Console.WriteLine(" Enter [{0},{1}] elements", i, j);
                    ar2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            if (ar1 == ar2)
            {
                s = 100;
            }
            else { 
            for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        if (ar1[i, j] == ar2[i, j])
                        {
                            s = s + p;
                        }
                   
                    }
                }
            }
             

            Console.WriteLine("Similarty of matrixs in  % = " + s);
            Console.WriteLine();
        }
    }
}
