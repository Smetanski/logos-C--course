using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    class Program
    {
        static void Main(string[] args)
        {
            Lines l = new Lines("Hello one man ");
            l.Rotate();
           
        }
    }
    abstract class Line
    {
        public string line; 
        public string Rotate()
        {
            string[] r = line.Split(' ');
            Stack<string> LINE = new Stack<string>();
            for ( int i = 0; i < r.Length; i ++ )
            {
                LINE.Push(r[i]);
            }
            string[] c = new string[r.Length] ;
            for ( int  i =0; i < r.Length; i ++)
            {
                c[i] = LINE.Pop();
            }
            return c.ToString();
        }

    }
    class Lines:Line
    {
        
        public Lines(string line)
        {
            base.line = line;
        }

    }
}
