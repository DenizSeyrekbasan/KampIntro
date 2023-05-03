using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerControlProjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerControlManager _customerControlManager = new CustomerControlManager(new CustomerValidationManager());
            _customerControlManager.Add(new Customer { FirstName = "Deniz", LastName = "SEYREKBASAN", CustomerId = 123 });

            Console.Read();
        }
    }
}
