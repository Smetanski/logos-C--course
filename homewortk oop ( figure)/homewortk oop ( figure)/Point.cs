using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homewortk_oop___figure_
{
    class Point
    {
        public  double x;
        public double y; 
        
        public  Point(double x ,double y )
        {
            this.x = x;
            this.y = y; 
        }
        public Point()
        {
            
        }
        public void Pointnumber()
        {
            
            Console.WriteLine("Enter coordinates of you poit (x,y) ");
            Console.Write("X = ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            y = double.Parse(Console.ReadLine());
        }

    }
}
