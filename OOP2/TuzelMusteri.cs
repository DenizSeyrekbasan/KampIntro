using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Coorporate - tuzel 
    //Miras - inheritance
    internal class TuzelMusteri:Musteri   
    {
        public string SirketAdi { get; set; } // sahıs adında bir instance olusturuyorsak sirket adı burada patlar (abstract hatası)
        public string VergiNo { get; set; }
    }
}
