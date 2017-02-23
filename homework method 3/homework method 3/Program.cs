using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_method_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("i=");
            int imax = int.Parse(Console.ReadLine());
            Console.Write("j=");
            int jmax = int.Parse(Console.ReadLine());
           int[,] ar1 = new int[imax, jmax];
            MatMetod(ref ar1  , imax , jmax );
        }
        static void MatMetod(  ref int[,] ar1  , int imax , int  jmax  )
        {
            int a = 0;
             ar1 = new int[imax, jmax];
            for (int j = 0; j < jmax; j++)
            {
                for (int i = 0; i < imax; i++)
                {
                    a++;
                    ar1[i, j] = a;
                    Console.Write("{0}\t" ,  ar1[i, j] );
                }
                Console.WriteLine();
            }
        }
        
    }
}
