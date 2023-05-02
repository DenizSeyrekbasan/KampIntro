using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpoyeeSystemControllDemo
{
    internal class EmployeeControlManager : IEmployeeControlService
    {
        EmployeeValidationManager employeeValidationManager;

        public EmployeeControlManager(EmployeeValidationManager employeeValidationManager)
        {
            this.employeeValidationManager = employeeValidationManager;
        }

        public void Delete(Employee employe)
        {
            Console.WriteLine("Deleted !");
        }

        public void Login(Employee employe)
        {
            Console.WriteLine("Successfuly !");
        }

        public void Update(Employee employe)
        {
            Console.WriteLine("Updated !");
        }
    }
}
