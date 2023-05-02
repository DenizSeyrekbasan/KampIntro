using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpoyeeSystemControllDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeControlManager employeeControlManager = new EmployeeControlManager(new EmployeeValidationManager());
            employeeControlManager.Login(new Employee { Name = "Deniz", LastName = "SEYREKBASAN", BusinessNumber = 123 });

            Console.Read();
        }
    }
}
