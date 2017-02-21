using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework___string_array_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your word ");
            //string b = Console.ReadLine();
            //while (b != "exit")
            //{
               string b = Console.ReadLine();
                char[] a = new char[b.Length]; //b.length - кількість знаків у b
                a = b.ToCharArray(); //конвертація string b в масив char a
                char[] c = new char[b.Length];
                for (int i = 0; i < b.Length; i++)
                {
                    c[i] = a[b.Length - i - 1]; // відтворення в другу сторону
                }
                int d = 0;
                for (int i = 0; i < b.Length; i++)
                {
                    if (a[i] != c[i]) d++;
                }
                
                for (int i = 0; i < b.Length; i++)
                {
                    if (a[i] != c[i]) d++;
                }
                if (d == 0) Console.WriteLine("Полином");
                else Console.WriteLine("Не полином");

          //  }

            Console.ReadKey();
        }
    }
}
  
