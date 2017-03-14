using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homewortk_oop___figure_
{
    class Trapeze : Figure
    {
        public string isequ;
        public double p;
        public double ar; 

        public Trapeze(double ab, double bc, double cd, double da , double bh) 
        {
            base.ab = ab;
            base.bc = bc;
            base.cd = cd;
            base.da = da;
            base.bh = bh; 

        }

        public Trapeze()
        {

        }

        public void perim()
        {
            p = ab + bc + cd + da;
        }

        public string isequal()
        {
            if (ab == cd)
            {
                return isequ = "equilateral";
            }
            else return isequ = "unequilateral";
        }
        public void area()
        {
            ar = ((bc + da) / 2) * bh;
        }

        public void Printinfo()
        {
            Console.WriteLine("Sides :\nAB = {0}\nBC = {1}\nCD = {2}\nDA = {3}\nH = {4}\nYour trapeze is - {5}\nPerimeter = {6}\nArea = {7} ", ab, bc, cd, da,bh ,  isequ, p , ar);
        }
    }
}
