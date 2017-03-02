using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16_17_oop
{
    class Employee : Person 
    {
        public const float minSalary = 1300;
        public string Company { get; set;  }
        private float salary; 
        public  Car companyCar ; 
        public  float Salary
        {
            get { return salary;  }
            set
            {
                if (value < minSalary)
                {
                    salary = minSalary;
                    Console.WriteLine("Salary set 1300$");
                }
                else salary = value;
            }
        }
        public Employee(long id, string name = "Uknown ",  string company = "Epam" ,   float salary = minSalary):base(id,name)
        {
            Console.WriteLine("Called from employee construc");
            Company = company;
            Salary = salary;
        }
    }
}
