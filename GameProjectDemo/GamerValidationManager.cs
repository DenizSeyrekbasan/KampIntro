using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class GamerValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "Deniz" && gamer.LastName == "SEYREKBASAN" && gamer.IdentityNumber == 123)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
