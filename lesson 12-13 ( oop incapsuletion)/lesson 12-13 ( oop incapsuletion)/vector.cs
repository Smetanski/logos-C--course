using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12_13___oop_incapsuletion_
{
    class vector
    {
        private float x;
        private float y;
        public float magn; 


        public float X
        {
            get
            {
                return x; 
            }
            set
            {
                x = value;
                CalcMagntude();

            }
        }
        
         
        public vector ( float x , float y)
        {
            this.x = x;
            this.y = y;
            CalcMagntude();
        }
        public void PrintInfo()
        {
            Console.WriteLine("X: {0}\nY: {1}\nMagnitude: {2}\n", x, y, magn);

        }

        private void CalcMagntude()
        {
            magn =  (float)Math.Sqrt(x * x + y * y);
        }

        public void SetX(float x )
        {
            this.x = x;
            CalcMagntude();
        }

        public void SetY(float y)
        {
            this.y = y;
            CalcMagntude();
        }
        public float GetX()
        {
            return x; 
        }
        public float GetY()
        {
            return y;
        }
        public float GetMagn()
        {
            return magn;
        }
        public float Y { get; set;  }
        public float Magn { get; set; } // скорецений ваірант 

    }
}
