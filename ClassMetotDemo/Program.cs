using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Deniz";
            musteri1.Soyadi = "Seyrekbasan";
            musteri1.Tc = "11111111111";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ali";
            musteri2.Soyadi = "Seyrekbasan";
            musteri2.Tc = "222222222222";

            Musteri[] musteriArray = new Musteri[] { musteri1,musteri2};

            MusteriManager yeni = new MusteriManager();
            yeni.ekle(musteri1);
            yeni.ekle(musteri2);

            Console.WriteLine("Listeleme");
            yeni.listele(musteri1);
            yeni.listele(musteri2);

            Console.WriteLine("silme");
            yeni.sil(musteri1);
            yeni.sil(musteri2);

            Console.Read();
            
        }
    }
}
