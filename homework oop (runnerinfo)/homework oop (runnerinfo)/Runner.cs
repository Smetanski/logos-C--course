using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_oop__runnerinfo_
{
    class Runner
    {
        private string name;
        private double time;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value; 
            }
        }
        public double Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value; 
            }
        }
        //public void mName(string name)
        //{
        //    this.name = name;
        //}
        //public void mTime(double time)
        //{
        //    this.time = time;
        //}
        public Runner(string name, double time)
        {
            this.name = name;
            this.time = time;
        }
        public Runner()
        {

        }
        public void Printinfo()
        {
            Console.WriteLine("Runner Name - {0} Time - {1}", name, time);
        }
    }
}
