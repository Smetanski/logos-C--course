using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_oop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 =  new Product(100, "Children", "Ball");
            Product p2 = new Product(130, "Adult", "Rocket");
            Product p3 = new Product(95, "Children", "Train");
            Product p4 = new Product(190, "Children", "Dog");
            Product p5 = new Product(75, "Old", "Walking stick");
            Product p6 = new Product(300, "Children" , "Skates");
            object[] Products = new object[] { p1, p2, p3, p4, p5, p6 };
           
            foreach(var el in Products)
            {

                if (el == "Children")
                {
                    el.PrintInfo();
                }
             } 
           
        }
       
    }
}
