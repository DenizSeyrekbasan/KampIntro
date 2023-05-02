using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deniz Seyrekbasan
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Deniz";
            musteri1.Soyadi = "Seyrekbasan";
            musteri1.TcNo = "1234567890";

            //Seyrekbasan Lmt. Şti
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Seyrekbasan Lmt. Şti";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri(); //Musteri class'ı hem GercekMusteri'nin hem de TuzelMusteri'nin REFERANS'ını tutabiliyor
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

           
        }
    }
}
