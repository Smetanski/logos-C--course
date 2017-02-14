using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_tupes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Розрахунок капіталовкладень з ***");
            Console.WriteLine("*** фіксованою нормою прибудку ***");
            decimal money, percent;
            int  j;
            const byte years = 15;
            money = 1000.0m;
            percent = 0.045m;
            for (j = 1; j <= years; j++) 
            {
                money *= 1 + percent;
            }
            Console.WriteLine("Загальний дохід за {0} років : {1} $$", years, money);
            Console.ReadLine();
        }
    }
}
