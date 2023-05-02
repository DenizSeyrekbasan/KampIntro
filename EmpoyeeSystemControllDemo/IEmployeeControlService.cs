using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpoyeeSystemControllDemo
{
    internal interface IEmployeeControlService
    {
        void Login(Employee employe);
        void Update(Employee employe);
        void Delete(Employee employe);
    }
}
