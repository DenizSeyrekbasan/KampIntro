using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.);

 
            Console.Read();

        }

        class MyList<T> //Generic class
        {
            T[] _array;

            public MyList()
            {
                _array = new T[0];
            }
            public void Add(T item)
            {
                
            }
        }
    }
}
