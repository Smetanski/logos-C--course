using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distans in kilometers");
            float km = float.Parse(Console.ReadLine());
            
            
            int pv = 30;
            float price = 0;
            
            if (km <= 10 )
            {
                price = (pv + km * 5); 
            }
            
            else if  (km <= 20)
            {
               price = (pv + km * 4);
            }
            
            else if (km > 20)
            {
                price = (pv + km * 3);
            }
            Console.WriteLine("Enter day time");
            string Daytime1 = Console.ReadLine();
            bool Daytime = (Daytime1 == "night");
           if (Daytime)
            {
                price = price / 2;
            }
            Console.WriteLine("You price is " + price);

        }
    }
}
