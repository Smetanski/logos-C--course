using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11__10____clas__
{
    class Computer
    {
       public string model;
       public  string proc;
       public  int ram;
        public bool isOn; 

        public void PrintInfo()
        {
            Console.WriteLine("Model : {0]\nProc: {1}\nRam: {2}", model, proc, ram);
        }
        public Computer(string p_model, string p_proc,  int p_ram)
        {
            model = p_model;
            proc = p_proc;
            ram = p_ram;
            Console.WriteLine(model + " Created"); 
        }
        public Computer()
        {
            model = " Unkwon";
            proc = "Unknown";
            ram = 0; 

        }
        public void TurnOn()
        {
            isOn = true; 
        }
        public void TurnOff()
        {
            isOn = false; 
        }
    }
}
