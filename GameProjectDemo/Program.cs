using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            Gamer gamer1 = new Gamer() { FirstName = "Deniz", LastName = "SEYREKBASAN", BirthYear = 2000, IdentityNumber = 123 };
            gamerManager.Add(gamer1);

            Console.Read();

        }
    }
}
