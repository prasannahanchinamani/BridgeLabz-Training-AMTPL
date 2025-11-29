using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class SalaryExeception: Exception
    {
      public SalaryExeception(string msg):base(msg) { }
    }
}
