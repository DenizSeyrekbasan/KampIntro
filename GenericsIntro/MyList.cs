using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T> //T tip parametresi kullandık, kullanıcıdan hangi veri türünde gelirse onu kullansın
    {
        T[] items;
        public MyList()
        {
            items = new T[0]; // newledigimiz anda array listi sıfırlamıs olduk
        }

        public void Add(T item)
        {
            T[] tempArray = items;//new'ledigimizde yeni referans numarası alır ve önceki elemanların uçmasını engeller, ucmasin diye o referans numarasını gecici bir diziye tutturduk
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //tempArray'in tuttugu verileri sırasıyla items'a atadık  
            }
            items[items.Length - 1] = item;//aslında eklenmek istenen elemanı suanda ekledik
                                           //-1 olmasınının sebebi son elemanın 1 eksigi, length eleman sayısı
        }
        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
