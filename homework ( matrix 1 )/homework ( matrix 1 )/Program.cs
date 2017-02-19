using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework___matrix_1__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix size ( colums = lines)");
            Console.WriteLine("Enter number of colums");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of lines");
            int l = int.Parse(Console.ReadLine());
            int[,] mat1 = new int[s,l];

            int sum = 0;
            for (int i = 0; i < s; i++)
            {
                for ( int j = 0; j < l; j++)
                {
                    Console.WriteLine("Enter [{0},{1}] elements", i,j);
                    mat1[i,j] = int.Parse(Console.ReadLine());
                    
                }
            }
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    
                    if (i==j || s-j-1 == i)
                    {
                        sum += mat1[i, j];
                    }
                    
                } 
            }
            Console.WriteLine("Sum = " + sum);

        }
    }
}
