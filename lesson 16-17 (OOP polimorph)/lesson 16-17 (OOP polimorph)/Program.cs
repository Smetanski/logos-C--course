using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16_17__OOP_polimorph_
{
    class Program
    {
        static void Main(string[] args)
        {
            OutStream os = new OutStream();
           // os.Write("Heloo");

            ConsoleOutput co = new ConsoleOutput();
            co.Write("Hello , console ");
            co.WriteLine("Hello , console");
            FileOutput fo = new FileOutput();
            fo.Write("Hello , file ");

            OutStream os1 = co;
            os1.Write("Hello, console out ");

            Console.WriteLine("Pleas enter your line ");
            string l = Console.ReadLine();
            Console.WriteLine("Pleas enter type of output :\n - Console\n - file");
            int action = int.Parse(Console.ReadLine());
            OutStream result =  null; 

            switch (action)
            {
                case 1:
                    
                    result = new ConsoleOutput(); 
                    break;
                case 2:
                    result = new FileOutput();
                    break;
                default:
                    Console.WriteLine("Errror");
                    break;

            } 
            if (result  != null)
            {
                result.Connect();
                result.Write(l);
                result.Close();
            }
           
        }
    }
}
