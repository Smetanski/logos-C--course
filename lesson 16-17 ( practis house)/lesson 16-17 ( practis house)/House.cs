using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16_17___practis_house_
{
    class House : LivingDemand 
    {
        private  string district;
        //public float externalarea;
        public float numofflats;

        public string District
        {
            get
            {
                return district;
            }
            set
            {
                if (district == "Center")
                {
                    value = "E class";
                }
                else if (district == "Shiv")
                {
                    value = "norm";
                }
                else district = value;  
            }
        }
        public House(float price = 0, float area = 0 , string distr = "Unknown"   , float extarea = 0 , float numofBeds = 0 ) :base(area ,numofBeds , price)
        {
            this.price = price; 
        }
    }
}
