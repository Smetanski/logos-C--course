using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_oop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hous h1 = new Hous(4, 10000 , 137);
            h1.PrintInfo();
            h1.MPrice(); 
        }
    }
}
