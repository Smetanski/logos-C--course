using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_leson_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Pleas,enter you marks ");
           
            string sub1 = "Math";
            string sub2 = "Physics";
            string sub3 = "Сhemistry";
            Console.WriteLine("Math ");
             float p1 =  float.Parse(Console.ReadLine());
            Console.WriteLine("Physics");
        
            float p2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Chemistry");
            float p3 = float.Parse(Console.ReadLine());
            Console.WriteLine(sub1 + " - " + "   " + p1);
            Console.WriteLine(sub2 + " - " + "   " + p2);
            Console.WriteLine(sub3 + " - " + "   " + p3);

            float Gpa;       
           
            Gpa = (p1 + p2 + p3)/3 ;
            
          
            Console.WriteLine("___________________________________");
            Console.WriteLine( " GPA = " +  Gpa );






        }
    }
}
