using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_oop_2
{
    class Product
    {
        public   int price ;
        public   string category;
        public   string name;
        //public Product(int price  = 0 , string categoty = "Unknown" , string name = "Unknown")
        //{
        //    this.price = price;
        //    category = category;
        //    this.name = name;
        //}
        public void  PrintInfo(/*int price, string category, string name*/)
        {
            Console.WriteLine("Price = {0}\nCategory = {1}\nName = {2}\n ", price, category, name);
            //return price;
            //return category;
            //return name; 
        }



    }
}
