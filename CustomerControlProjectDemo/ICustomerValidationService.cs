using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerControlProjectDemo
{
    internal interface ICustomerValidationService
    {
        bool validate(Customer customer);
    }
}
