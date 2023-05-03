using CustomerControlProjectDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerControlProjectDemo
{
    internal class CustomerControlManager : ICustomerInformationService
    {
        CustomerValidationManager _customerValidatonManager;

        public CustomerControlManager(CustomerValidationManager customerValidatonManager)
        {
            _customerValidatonManager = customerValidatonManager;
        }

        public void Add(Customer customer)
        {
            Console.WriteLine("Eklendi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Guncellendi");
        }
    }
}
