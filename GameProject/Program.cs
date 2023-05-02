using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Add(new Gamer { BirthYear = 2000, FirstName = "Deniz", LastName = "SEYREKBASAN", IdentityNumber = 123 });

            Console.Read();
        }
    }
}
