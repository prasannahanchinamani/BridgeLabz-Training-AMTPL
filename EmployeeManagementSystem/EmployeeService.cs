using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class EmployeeService : IEmployeeService
    {
        private List<Employee> employeeList = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
             if (employeeList.Contains(employee))
            {
                Console.WriteLine("Employee is  already exists.");
                return;
            }

            employeeList.Add(employee);
            //Console.WriteLine("Employee added successfully");
        }
        
        public void UpdateEmployee(int id, string name, string email, double salary)
        {
            if (employeeList.Count <= 0)
            {
                Console.WriteLine("Not possible");
            }

            foreach (Employee emp in employeeList)
            {
                if (emp.Id == id)
                {
                    emp.Name = name;
                    emp.Email = email;
                    emp.Salary = salary;
                }
                else
                {
                    Console.WriteLine("Employee Not Found");
                }

                //Console.WriteLine("Employee Updated succcessfully");
            }
        }
        public void DeleteEmployee(int id)
        {
            if (employeeList.Count <= 0)
            {
                Console.WriteLine("Not possible");
            }

            foreach (Employee emp in employeeList)
            {
                if (emp.Id == id)
                {
                    employeeList.Remove(emp);
                }
            }
            //Console.WriteLine("Employee Deleted succcessfully");
        }
        public void DisplayEmployees()
        {
            if (employeeList.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            employeeList.Sort((a, b) => a.Name.CompareTo(b.Name));

          
            foreach (Employee emp in employeeList)
            {
                Console.WriteLine($"ID: {emp.Id}");
                Console.WriteLine($"Name: {emp.Name}");
                Console.WriteLine($"Email: {emp.Email}");
                Console.WriteLine($"Salary: {emp.Salary}");
                Console.WriteLine("----------------------");
            }
        }

    }
}
