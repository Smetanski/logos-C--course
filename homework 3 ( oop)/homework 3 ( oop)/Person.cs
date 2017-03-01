using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3___oop_
{
    class Person
    {
        public string name;
        public string surname;
        public byte height; 
        public byte  age ;
        public string male;
        public string IsAlive;
        public Person() { } 
        public Person(string name)
        {
            this.name = name; 
        }
        public Person(string name , string surname)
        {
            this.name = name;
            this.surname = surname; 
        }
        public Person(string name ,string surname , byte height)
        {
            this.name = name;
            this.surname = surname;
            this.height = height; 
        }
        public Person(string name , string surname , byte height , byte age)
        {

        }
    }
}
