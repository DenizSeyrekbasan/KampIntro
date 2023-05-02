using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpoyeeSystemControllDemo
{
    internal class EmployeeValidationManager : IEmployeeValidationService
    {
        public bool Validate(Employee employee)
        {
            if (employee.Name == "Deniz" && employee.LastName == "SEYREKBASAN" && employee.BusinessNumber == 123)
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
