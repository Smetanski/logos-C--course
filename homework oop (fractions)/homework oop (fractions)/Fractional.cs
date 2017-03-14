using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_oop__fractions_
{
    class Fractional : Integer
    {
        private  long Numerator;
        private int FPart;
        private long sum;
        private long subtraction;
        private long multipl;
        public string siml; 
        public Fractional()
        {

        }
        public Fractional(long Numerator, int FPart)
        {
            this.Numerator = Numerator;
            this.FPart = FPart;
        }
        public long numerator
        {
            get { return Numerator; }
            set { Numerator = value; }
        }
        
        public int fpart
        {
            get { return FPart; }
            set { FPart = value;  }
        }
       

        public long Addition
        {
            get { return sum = numerator + fpart;  }
        }

        
        public long Subtraction
        {
            get { return subtraction = numerator - fpart; }
        }
        public long Multipl
        {
            get { return multipl = numerator * fpart;  }
        }

        public void Simil()
        {
                if (numerator > fpart)
                {
                   siml = " Numerrator bigger";
                }
                else if (numerator < fpart)
                {
                     siml = " Fractional part bigger ";
                }
                else if (numerator ==  fpart)
                {
                    siml= "Numerator = Fractoinal part ";
                } 
                 
        }

        public void Printinfo()
        {
            Console.WriteLine("Your numerator  = {0}\nYour fractoinal part = {1}\nSum = {2}\nSubtr = {3}\nMultiplying = {4}\nSimile - {5}", Numerator, FPart, Addition , Subtraction , Multipl , siml);
        }
    }
} 
