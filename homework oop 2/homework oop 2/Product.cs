using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_oop_2
{
    class Product
    {


        public double price;
        public string category;
        public string name;

        public Product(int price, string categotry , string name )
        {
            this.price = price;
            this.category = categotry;
            this.name = name;
        }
        public Product()
        {

        }
        public void PrintInfo()
        {
            Console.WriteLine("Price = {0}\nCategory = {1}\nName = {2}\n ", price, category, name);

        }




    }
}
