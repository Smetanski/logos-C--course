using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16_17___practis_house_
{
    class LivingDemand
    {
        public static float pricepermeter = 250;
        public float livingarea;
        public float extarea;
        public  float area;
        public  float price;
        public int numofBeds; 
        public float Price
        {
            get { return price; }
            set
            {
                area = livingarea + extarea;
                price = pricepermeter * area; 
            }
        }
        public int  NumofBeds
        {
            get { return numofBeds; }
            set
            {
                if (area < 50)
                {
                    value = 1; 
                }
               else if (area <= 100)
                {
                    value = 2; 
                }
                else if (area >= 200)
                {
                    value = 3; 
                }
                if (area > 200)
                {
                    value = 5;
                }
                else numofBeds = value; 
            }

        }
        public LivingDemand(float area , float livingarea ,float extarea , float numofBeds , float price  )
        {
          
        }
    }
}
