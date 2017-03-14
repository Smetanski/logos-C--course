using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework__stack_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<string> sumbols = new Stack<string>();
            //int Count = 0; 
            //sumbols.Push("1");
            //sumbols.Push("1фі");
            //sumbols.Push("1");
            //sumbols.Push("_йц");
            //sumbols.Push("1");
            //sumbols.Push("4");
            //sumbols.Push("1");
            //foreach( var s in sumbols)
            //{
            //    if(s == "1")
            //    {
            //        Count++;
            //    }
            //}
            //if ( Count % 2 ==0)
            //{
            //    Console.WriteLine(" Pair number  of  1 ");
            //}
            //else if (Count % 2 != 0)
            //{
            //    Console.WriteLine("Not pair number  of  1 ");
            //}
            Console.WriteLine(ChecCharLine("al1dj4nv jq1kbjb 21j2bjb3j12 1 b311v 2vu3 21"));
        }
            public static string ChecCharLine(string line)
        {
            Stack<char> Line = new Stack<char>();
            
            for ( int i = 0; i < line.Length;  i++)
            {
                if ( line[i] == '1')
                {
                   Line.Push(line[i]); 
                }
            }
            if (Line.Count % 2 == 0) return " Pair number  of  1 ";

             return "Not pair number  of  1 ";


        }

        
    
    }
}
