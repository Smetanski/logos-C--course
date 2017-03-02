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
                    value = "nor";
                }
                else district = value;  
            }
        }
        public House(string distr = "Unknown" , float area = 0  , float extarea = 0 , float numofbed = 0 ,float price = 0 , float livingarea = 0   ):base(area , extarea , livingarea ,numofbed , price)
        {

        }
    }
}
