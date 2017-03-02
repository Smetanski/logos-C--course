using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework___oop_Studentinfo_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 6, 7, 5, 9, 10, 11, 5, 9, 12 };
            Student s1 = new Student(array);
            s1.name = "Paul";
            s1.adrress = "Drag 99 . st";
            
            PrintInfo(s1.name , s1.adrress ,s1.avg);

        }
        public  static void PrintInfo(string name , string adrress ,double avg)
        {
            Console.WriteLine("Name  -  {0}\nAddress -{1}\nAvg = {2}", name, adrress, avg);
        }
    }
}
