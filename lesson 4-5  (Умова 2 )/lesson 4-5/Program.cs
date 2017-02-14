using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_5
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int num = int.Parse(Console.ReadLine());
            if (num % 100 == 0) 
            { Console.WriteLine("Dil na 100 "); }
            else if ( num % 36 == 0 )
            {
                Console.WriteLine("Dil na 36 ");
            }
            switch (num % 2) { 
                case 0:
                    Console.WriteLine("Perne");
                    break;
                case 1:
                    Console.WriteLine("Neprne");
                    break;

             }*/
            Console.WriteLine("Enter your drink");
            string drink = Console.ReadLine().ToLower().Trim();
           // drink = drink.ToLower();
           // drink  = drink.Trim();
            switch (drink)
            {
                case "Latte":
                case "latte":
               
                    Console.WriteLine("Hear is your Latte 15$ ");
                    break;
                case "Americano":
                    Console.WriteLine("Hear is your americano 10$ ");
                    break;
                default:
                    string newDrink = drink.Contains("tea") ? "tea" : drink;
                    if (newDrink == "tea")
                        Console.WriteLine("Here is you tea ; 7$ "); 
                    else 

                    Console.WriteLine("Wrong drink name ");
                    break;
            }
        }
       //int num = int.Parse(Console.ReadLine());
       // bool isEven = num % 2 == 0 ? true : false;    
            }
}
