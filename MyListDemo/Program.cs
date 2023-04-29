using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> araclar = new MyList<string>();
            araclar.Add("Audi");

            Console.Read();
        }
    }
}
