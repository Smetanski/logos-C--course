using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12_13___oop_incapsuletion_
{
    class Program
    {
        static void Main(string[] args)
        {
            vector v1 = new vector(3, 4);
            //v1.SetX(100);
            v1.X = 150; 
            //v1.SetY(126);
            //float magn = v1.GetMagn();
            //Console.WriteLine(magn); 

           v1.PrintInfo(); 

        }
    }
}
