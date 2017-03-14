using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_oop___vector_
{
    class Vector
    {


        private float x;

        private float y;

        private float magn;

        public Vector(float x, float y)

        {

            this.x = x;

            this.y = y;

            
        }
        public Vector()
        {
            
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
           get { return y; }
            set { y = value; }
        }
        public float Magn
        {
            get { return magn ; }
            set { magn = (float)Math.Sqrt(X * X + Y * Y); }
        }

        public void Pointnumber()
        {
            Console.WriteLine("Enter coordinates of you poit (x,y) ");
            Console.Write("X - ");
            X = float.Parse(Console.ReadLine());
            Console.Write("Y - ");
            Y = float.Parse(Console.ReadLine());
            magn = (float)Math.Sqrt(X * X + Y * Y);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Vector - {0}\nX - {1}\nY - {2}\nMagnityde - {3}" ,  X , Y , Magn); //
 
        }


    }
        
}
