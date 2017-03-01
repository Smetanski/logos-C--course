using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_practic
{
    class Program
    {
        static void Main(string[] args)
        {
          
           
            OutPut( Calc1(6));
            Console.WriteLine();
        }
         static int[] Calc1( int n )
        {
            int[] ar = new int[n];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = i ;
            }
           
            return ar; 
        }
        static int[] OutPut( int[] ar )
        {
          
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write("{0}\t ", ar[i]);
            }
            Console.WriteLine();
            return ar; 
        }
        //static int Fibo(int n)
        //{
        //    if (n == 1 || n == 2) return 1 ;
        //    return Fibo(n - 1) + Fibo(n + 2); 

        //}
              
    }
}
