using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16_17_oop
{
    class Person
    {
        private string fullname;
        public string FullName
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value; 
            }
        }
        private int age;
        private string nationality; 


        public void incAge()
        {
            age++; 
        }
        public string Nationality
        {
            get
            {
                return nationality;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "ua":
                    case "uk ":
                    case "ukrainian":
                    case "ukraine" :
                        nationality = "ua";
                        break;
                    default:
                        nationality = "unknown";
                        break;
                }
            }
        }
        public readonly long id; 
        public Person (long id  ,string name = "Uknown " , int age = 0 , string nat = "unknown")
        {
            this.id = id;
            fullname = name;
            this.age = age;
            Nationality = nationality; 
        }
        public void PrintInfo()
        {
            Console.WriteLine("Person id  = #{0}\nFull name : {1}\nAge : {2}\nContry : {3} ", id , fullname ,age, nationality  );
        }
    }
}
