using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homewortk_oop___figure_
{
     abstract class Figure : Point
    {
        public double ab;
        public double bc;
        public double cd;
        public double da;
        public double bh;
       
        
        Point a = new Point();
        Point b = new Point();
        Point c = new Point();
        Point d = new Point();
        Point h = new Point();
       
        public Figure(double ab, double bc, double cd, double da)
        {
            
        }

        public Figure()
        {
            Console.WriteLine("Point a ");
            a.Pointnumber();
            Console.WriteLine("Point b ");
            b.Pointnumber();
            Console.WriteLine("Point c ");
            c.Pointnumber();
            Console.WriteLine("Point d ");
            d.Pointnumber();
            Console.WriteLine("Point h ");
            h.Pointnumber();
        }

        public void SideLenght()
        {
            ab = Math.Sqrt((b.x - a.x) * (b.x - a.x) - (b.y - a.y) * (b.y - a.y));
            bc = Math.Sqrt((c.x - b.x) * (c.x - b.x) - (c.y - b.y) * (c.y - b.y));
            cd = Math.Sqrt((d.x - c.x) * (d.x - c.x) - (d.y - c.y) * (d.y - c.y));
            da = Math.Sqrt((a.x - d.x) * (a.x - d.x) - (a.y - d.y) * (a.y - d.y));
            bh = Math.Sqrt((h.x - b.x) * (h.x -b.x) - (h.y - b.y) * (h.y - b.y));
        }

    }
}
