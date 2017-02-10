using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string p1 = "Sup";
            string p2 = "Beer";
            string p3 = "Beacon";
            float price1 = 14.99f;
            float price2 = 17.99f;
            float price3 = 18.99f;
            string waiter = "Sem";
            float sum = price1 + price2 + price3;

            Console.WriteLine("Bill: " + waiter);
            Console.WriteLine(p1 + "    " + "$" + price1);
            Console.WriteLine(p2 + "    " + "$" + price2);
            Console.WriteLine(p3 + "    " + "$" + price3);
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Sum    " + sum);

        }
    }
}
