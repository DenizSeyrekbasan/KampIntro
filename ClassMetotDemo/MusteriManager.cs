using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        
        public void ekle(Musteri musteri)
        {
            Console.WriteLine("musteri adi : " + musteri.Adi);
            Console.WriteLine("musteri soyadi : " + musteri.Soyadi);
            Console.WriteLine("musteri tc : " + musteri.Tc);
        }
        public void sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi ! " + musteri);
        }
        public void listele(Musteri musteri)
        {
            Console.WriteLine("Adı : " + musteri.Adi);
            Console.WriteLine("Adı : " + musteri.Soyadi);
            Console.WriteLine("Adı : " + musteri.Tc);
        }
    }
}
