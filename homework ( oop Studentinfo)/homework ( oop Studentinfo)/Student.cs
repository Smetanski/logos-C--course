using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework___oop_Studentinfo_
{
    class Student
    {
        private string Name;
        private string Adrres;
        private double Avg ;
        private  int[] _points; 
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string adrress
        {
            get
            {
                return Adrres;
            }
            set
            {
                Adrres = value; 
            }
        }
        public double avg
        {
            get
            {
                CalcAvg();
                return Avg;
            }
        }

        public Student(int[] point)
        {
            _points = point; 
        }
        private void CalcAvg()
        {
            double sum = 0;
            foreach (var item in _points)
            {
                sum += item;
            }
            { 
            Avg = sum / _points.Length;
            }
        }


    }
}
