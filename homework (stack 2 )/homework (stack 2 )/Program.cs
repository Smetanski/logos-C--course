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
            Console.WriteLine(SimilChec("1230321"));
        }
        public static string SimilChec(string line)
        {
            Stack<char> Line = new Stack<char>();
          // char[] nline = new Char[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != '0')
                {
                    Line.Push(line[i]);
                }
                 else if (line[i] == '0')
                {
                    Line.Pop();
                }

                else if (line.First() == line.Last())
                {
                    // if (Line.Count() == 0) return "Error";
                    Line.Pop();
                }
           }
            Console.WriteLine(line);
            if (Line.Count == 3) return "Simetric";
                return " Not Simetric";
            
        }

    }
}
