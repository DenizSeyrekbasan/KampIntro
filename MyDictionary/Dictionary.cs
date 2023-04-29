using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Dictionary<T1,T2> // T1 ve T2 adında iki degisken 
    {
        T1[] items1;
        T2[] items2;
        T1[] _tempArray1; // gecici array
        T2[] _tempArray2; //gecici array

        public Dictionary() //constructor olusturdum
        {
            items1 = new T1[0]; //yeni array olusturduk
            items2 = new T2[0];
        }

        public void Add(T1 item1,T2 item2)
        {
            _tempArray1 = items1;
            _tempArray2 = items2;
            items1 = new T1[items1.Length + 1];
            items2 = new T2[items1.Length + 1];

            for (int i = 0; i < _tempArray1.Length; i++)
            {
                items1[i] = _tempArray1[i];
                items2[i] = _tempArray2[i];
            }

            items1[items1.Length - 1] = item1;
            items2[items2.Length - 1] = item2;
        }
    }    
}
