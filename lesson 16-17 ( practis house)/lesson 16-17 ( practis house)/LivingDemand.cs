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
        public  float area;
        public  float price;
        public int numofBeds;
        public float Price
        {
            get { return price; }
            set
            {
                price = value;
                price = pricepermeter * area;
            }
        }
        public int  NumofBeds
        {
            get { return numofBeds; }
            set
            {
                numofBeds = value;
                if (area < 50)
                {
                    value = 1;
                    numofBeds = value;
                }
               else if (area <= 100)
                {
                    value = 2;
                    numofBeds = value;
                }
                else if (area <= 200)
                {
                    value = 3;
                    numofBeds = value;
                }
                if (area > 200)
                {
                    value = 5;
                    numofBeds = value;
                }
              
            }

        }
        public LivingDemand(float area ,float numofBeds , float price )
        {
            this.price = Price; 
        }
        public LivingDemand()
        {

        }
        public void PrintInfolive()
        {
            Console.WriteLine("Area = {0}\nNum of Beds = {1}\nPrice = {2}", area, numofBeds, price); 
        }
    }
}
