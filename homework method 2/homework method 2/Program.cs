using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_method_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Metod("Hello", 3 , 7 ,12);
            Console.ReadKey();
        }
        static void  Metod( string t ,int a, int b, int c )
        {
            //t = "Hello";
            int sum = a + b + c;
            if ( sum > 20)
            {
                Console.WriteLine(t); 
            }
            if (sum  < 20)
            {
                Console.WriteLine("Sorry but sum  =" + sum);
               
            }
        }
        
    }
}
