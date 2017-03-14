using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16_17___practis_house_
{
    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House();
            LivingDemand l1 = new LivingDemand();
            l1.area = 140; 
           // l1.numofBeds =3 ;
            l1.PrintInfolive();
            //h1.area = 140;
            //h1.District = "Center";
            //h1.numofflats = 3; 
            //h1.PrintInfolive();
           
        }
    }
}
