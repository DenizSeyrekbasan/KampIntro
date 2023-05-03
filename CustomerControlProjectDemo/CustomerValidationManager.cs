using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerControlProjectDemo
{
    internal class CustomerValidationManager : ICustomerValidationService
    {
        public bool validate(Customer customer)
        {
            if (customer.FirstName == "Deniz" && customer.LastName == "SEYREKBASAN" && customer.CustomerId == 123)
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
