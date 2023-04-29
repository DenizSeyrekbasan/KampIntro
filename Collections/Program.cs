using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Deniz","Ali","Murat","Ahmet" };
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string>() { "Deniz", "Ali", "Murat", "Ahmet" };
            Console.WriteLine(isimler2[0]);


            Console.Read();
        }
    }
}
