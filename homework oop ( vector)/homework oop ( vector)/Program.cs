using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_oop___vector_
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector();
            Vector v2 = new Vector();
            Vector v3 = new Vector();
            Vector v4 = new Vector();
            Vector v5 = new Vector();
            Vector v6 = new Vector();
            Vector v7 = new Vector();
            Vector v8 = new Vector();
            Vector v9 = new Vector();
            Vector v10 = new Vector();
            Vector[] Varr = new Vector[] {v1,v2,v3,v4,v5,v6,v7,v8,v9,v10 };
            Console.WriteLine("Vectors array");
            for ( int i = 0; i < Varr.Length; i ++)
            {
                Console.WriteLine("Vector {0}", i+1);
                Varr[i].Pointnumber();
                
            }

            foreach (var el in Varr)
            {

                el.PrintInfo(); //
                
            }
            Console.WriteLine("Vectors ( magnityde > 5)");
            foreach (var elm in Varr)
            {
                if (elm.Magn > 5)
                {
                    elm.PrintInfo();
                  
                }
            }
            
        }
    }
}
