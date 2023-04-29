using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id = 1, FirstName = "Deniz", LastName = "Seyrekbasan", City = "Antalya" }; // bu ve customer2 aynı kullanım

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Ahmet";
            customer2.LastName = "Seyrekbasan";
            customer2.City = "İstanbul";

            Customer customer3 = new Customer(2, "Ali", "Seyrekbasan", "Ankara"); //iki farklı constructor kullandık

            Console.WriteLine(customer3.FirstName);


            Console.Read();
        }
    }
    
    class Customer
    {
        public Customer() //constructor1
        {

        }
        //default constructor : parametresi olmayan constructor
        public Customer(int id, string firstName, string lastName, string city) //constructor2
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

    
}
