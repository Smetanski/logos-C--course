using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_7__практика1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] ar1 = new int[10];
            {
                for (int i = 0; i < 10; i++)
                {
                    int num;
                    ar1[i] = rand.Next(-7, 18);
                    num = i ;
                  
                    if ( num % 2 == 0 )
                    {
                        ar1[i] = ar1[i] - 1;
                    }
                    
                    
                    if (num > 100)
                    {
                        ar1[i] = 99;
                    }
                }
                for(int i = 0; i < ar1.Length; i++)

            {
                    

                        Console.Write(ar1[i] + "\t");

                    }

                    Console.WriteLine();
                } 

        }
    }
}
