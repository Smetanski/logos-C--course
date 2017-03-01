using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11__10____clas__
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            Computer c1 = new Computer ( "Lenovo" , "i7" , 4056 );
           
            Computer my = new Computer();
           
          
            c1.PrintInfo();
            my.PrintInfo();
            my.TurnOn();
            Console.WriteLine(my.isOn);
        }
    }
}
