using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16_17__OOP_polimorph_
{
    class OutStream
    {
        public OutStream()
        {

        }
        public  virtual void Write(string line = "")
        {
            Console.WriteLine("Error! You can't write to OutStrem");
        }
        public  virtual void WriteLine(string line = "")
        {
            Write();
        }
        public bool TryWrite(string line = "")
        {
            Write();
            return false ;
        }
        public virtual void Connect()
        {

        }
        public virtual void Close()
        {

        }
    }
}
