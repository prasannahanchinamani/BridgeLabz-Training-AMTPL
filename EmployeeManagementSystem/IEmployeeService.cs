using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal interface IEmployeeService
    {
        void AddEmployee(Employee employee);
        void UpdateEmployee(int id, string name, string email, double salary);
        void DeleteEmployee(int id);
        void DisplayEmployees();

  }

}
