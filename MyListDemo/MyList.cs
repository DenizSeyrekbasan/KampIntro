using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListDemo
{
    internal class MyList<T> //T tip parametresi kullanıyoruz
    {
        T[] items;

        public MyList()
        {
            items = new T[0]; // kod blogu calistiği anda arrayimiz sıfırlansın
        }

        public void Add(T item)
        {
            T[] tempArray = items; // yeni array'de referans numaraları kayboldugu icin gecici bir array olusturup eski data'larımızı burada tutuyoruz
            items = new T[items.Length + 1]; //new array'imiz 0'dı alanı bir artırıyoruz her seferinde

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // tempArray'in tuttugu elemanları indis numaralarına göre aktarma islemi                
            }
            items[items.Length - 1] = item;
        }
    }
}
