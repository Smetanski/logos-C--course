using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16_17__OOP_polimorph_
{
    class ConsoleOutput : OutStream
    {
        public override  void Write ( string line = "")
        {
            Console.WriteLine(line);
        }
        public override   void WriteLine(string line = "")
        {
            Console.WriteLine(line);
        }
        public  new bool TryWrite(string line = "")
        {
            Console.WriteLine(line);
            return true; 
        }
    
    public override void Connect()
    {
        Console.WriteLine("File opened ");
    }
    public override void Close()
    {
        Console.WriteLine("Console deleted");
    }

}
