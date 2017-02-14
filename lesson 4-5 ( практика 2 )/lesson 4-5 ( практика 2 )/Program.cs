using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_5___практика_2__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть суму покупок ");
            int s = int.Parse(Console.ReadLine());
            if (s >= 1000)
            {
                Console.WriteLine("Вітаю ви отримуєте  15% знижку " + "ціна із знижкою " + ((s * 0.85)));
            }
            if ( s < 1000)
            {
                Console.WriteLine("Потрібно - " +( 1000 - s));
            }
        }
    }
}
