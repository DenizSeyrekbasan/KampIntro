using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> CitiesNumbers = new Dictionary<int,string>();
            CitiesNumbers.Add(06,"Ankara");
            

            Console.WriteLine(CitiesNumbers[6]);


            Console.Read();
        }
    }
}
