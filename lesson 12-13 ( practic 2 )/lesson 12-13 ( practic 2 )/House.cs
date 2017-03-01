using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12_13___practic_2__
{
    class House
    {
        private static float pricePermater = 220;
        private float numofrooms { get; set; }
        private float area { get; set; }
        private float numofBathrooms { get; set; }
        private float Price { get; set; }

        public House(float area)
        {
            this.area = area;
            CalcPrice();
        }
       //private Room[] rooms = new Room[10];

        public void CalcPrice()
        {
            Price = (float)pricePermater * area;

        }
        public void PrintPrice()
        {
            Console.WriteLine("Price = " + Price);

        }
    }
}
