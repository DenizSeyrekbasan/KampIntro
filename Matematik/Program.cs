using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplama : 1");
            Console.WriteLine("Çıkarma : 2");
            Console.WriteLine("Carpma : 3");
            Console.WriteLine("Bolme : 4");
            
            Console.Write("İşlem türünü seçiniz : ");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("Sayi 1 : ");
                int s1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Sayi 2 :");
                int s2 = int.Parse(Console.ReadLine());

                DortIslem yeni = new DortIslem();
                yeni.Topla(s1, s2);
                
            }

            Console.Read();

        }
    }
}
