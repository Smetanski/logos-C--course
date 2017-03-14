using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework__stack_2__
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "1230321";
            Console.WriteLine(SimilChec(line));
        }
        public static string SimilChec(string line)
        {
            Stack<char> Line = new Stack<char>();
            for (int i = 0; i < line.IndexOf('0'); i++)
            {

                Line.Push(line[i]);
            }
                
                for (int i = 1; i < line.Length; i ++  )

                 if ( line[i]  - Line.Peek() == 0 )
                {
                 
                    Line.Pop();
                }
           
            Console.WriteLine(line);
            if (Line.Count == 0) return "Simetric";
                return " Not Simetric";
            
        }

    }
}
