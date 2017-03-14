using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homewortk_oop___figure_
{
    class Program
    {
        static void Main(string[] args)
        {
             Trapeze t1 = new Trapeze();
            Trapeze t2 = new Trapeze();
            Trapeze t3 = new Trapeze();
            Trapeze[] at = new Trapeze[] { t1, t2, t3 };

            for (int i = 0; i < at.Length; i++)
            {
                at[i].SideLenght();
                at[i].isequal();
                at[i].perim();
                at[i].area();
                at[i].Printinfo();
                double avgar = (at[i].ar + at[i + 1].ar + at[i + 2].ar) / 3;
                if ( at[i].ar > avgar)
                {
                    Console.WriteLine(at[i]);
                }
            }
            
         

        }
    }
}
