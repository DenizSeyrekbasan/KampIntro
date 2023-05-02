using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpoyeeSystemControllDemo
{
    internal interface IEmployeeValidationService
    {
        bool Validate(Employee employe);
    }
}
