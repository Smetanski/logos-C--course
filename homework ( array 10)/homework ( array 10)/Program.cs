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
            
            Console.WriteLine("Firs matrix");
            int[,] ar1 = new int[3, 4];
           // Random rand = new Random();
            float p = 8.33f; // залежить від кількості елементів у матриці => 100/n
            float s = 0; 
            
            for ( int i = 0; i < 3; i++)
            {
                for ( int j = 0; j < 4; j++)
                {
                    // ar1[i, j] = rand.Next(10);
                    Console.WriteLine(" Enter [{0},{1}] elements", i, j);
                    ar1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Second matrix");
            int[,] ar2 = new int[3, 4];
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
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
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (ar1[i, j] == ar2[i, j])
                        {
                            s = s + p;
                        }
                        // else if ( s == 99.96001)
                        // {
                        //    s = 100;
                        //}
                    }
                }
            }        

            Console.WriteLine("Similarty of matrixs in  % = " + s);
            Console.WriteLine();
        }
    }
}
