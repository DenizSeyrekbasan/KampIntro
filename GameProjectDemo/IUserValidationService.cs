using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    //Kullanici dogrulama servisi 
    internal interface IUserValidationService
    {
        bool Validate(Gamer gamer); 
        //once her zaman ınterface olustur, sablon olustur
        //service'i interface olarak olustur
    }
}
