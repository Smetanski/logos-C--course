using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16_17_oop
{
    class Car
    {
        private string model;
        private int numofWheels; 
        public Car(string m   = " Unknown " , int num = 4)
        {
            model = m;
            numofWheels = num; 
        }
        public void PrintInfo()
        {
            Console.WriteLine("Model = {0}\nNum Of Wheels {1}", model, numofWheels); 
        }
    }
}
