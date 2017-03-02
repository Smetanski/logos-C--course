using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16_17_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p1 = new Employee(4414, "Paul", "Elect" , 3500);
            p1.incAge();
            p1.PrintInfo();
            p1.companyCar = new Car("Audi", 4);
            p1.companyCar.PrintInfo(); 
        }
    }
}
