using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_oop_1
{
    class Hous
    {
        //public int NumOfRooms;
        //public int Price;
        //public float area;
        private int v1;
        private int v2;
        private int v3;

        public Hous(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public void PrintInfo()

        {

            Console.WriteLine("Number of rooms : {0}\nPrice: {1}\nArea: {2}", v1, v2, v3);

        }

        public void MPrice()
        {
            Console.WriteLine("Price for square Meter = " + v2 / v3);
        }

    }

}
