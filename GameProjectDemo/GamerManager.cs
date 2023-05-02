using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    //MicroService
    internal class GamerManager : IGamerService // inheritance, sonrasında implement ediyoruz
    {
        //gamerManager'da constructor olusturduk ve bunun artık bagimliligi var
        //gamerManager servisinin içerisinde dogrulama servisini kullan
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)  
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Welcome !" + gamer);
            }
            else
            {
                Console.WriteLine("Wrong account !");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted !");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated !");
        }
    }
}
