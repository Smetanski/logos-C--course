using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_oop__runnerinfo_
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner r1 = new Runner();
            Runner r2 = new Runner("Tim", 14);
            Runner r3 = new Runner("Ben", 15);
            Runner r4 = new Runner("John", 13.5);
            r1.Name = "Paul";
            r1.Time = 13.2;
            Runner[] timetable = new Runner[] { r1, r2, r3, r4 };
            string leader = "";
            Console.WriteLine("Runners Time Board");
            double max = double.MinValue;
            foreach (var item in timetable)
            {      
                if (item.Time > max)
                {
                    max = item.Time;
                    leader = item.Name;

                }

                Console.WriteLine("Name - {0}  Time - {1} " ,  item.Name , item.Time);
            }
            Console.WriteLine("Leader of the run  - {0} ", leader);
        }
    }
}
