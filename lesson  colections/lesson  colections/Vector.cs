using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson__colections
{
    class Vector : IPrintable , ICloneable
    {
        private float _x;
        private float _y;
        private float _magn;
        public float X
        {
            get { return _x; }
            set { _x = value; }

        }
        public float Y
        {
            get { return _y; }
            set {
                _y = value;
                CalcMagntude();
                }

        }
        public float Magn
        {
            get { return _magn; }
            

        }
        public Vector(float px = 0 ,float py = 0)
        {
            X = px;
           Y = py;
        }
         public void CalcMagntude()
        {
            _magn =(float)Math.Sqrt(X* X - Y*Y);
        }
        public void Print()
        {
            Console.WriteLine("X = {0}; Y = {1} ; Magn = {2}", X, Y, Magn);
        }
        public Vector Clone()
        {
            return MemberwiseClone() ;
        }
        
    }
}
