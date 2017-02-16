using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_7._1___while_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int result = 15;
             while (result < 1000000) ;
             {
                 //  Console.WriteLine(result);
                 result *= 15;                // result = result * 15 ;
             }
             Console.WriteLine(result);}*/
             //далі одновимірний масив
           /* int[,] ar2 = new int[3, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Enter  [{0},{1}] element", i, j);
                    ar2[i, j] = int.Parse(Console.ReadLine());
                }
            }    for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine(ar2[i, j]);
                    }
                    Console.WriteLine();
                }
            */
            // Далі східчастий масив
            int[][] ar3 = new int[3][];

            for (int i = 0; i < ar3.Length; i++)

            {

                ar3[i] = new int[i + 1];

            }



            for (int i = 0; i < ar3.Length; i++)

            {

                for (int j = 0; j < ar3[i].Length; j++)

                {

                    Console.WriteLine("Enter [{0}][{1}] element", i, j);

                    ar3[i][j] = int.Parse(Console.ReadLine());

                }

            }



            for (int i = 0; i < ar3.Length; i++)

            {

                for (int j = 0; j < ar3[i].Length; j++)

                {

                    Console.Write(ar3[i][j] + "\t");

                }

                Console.WriteLine();

            }
        }
    }
}
