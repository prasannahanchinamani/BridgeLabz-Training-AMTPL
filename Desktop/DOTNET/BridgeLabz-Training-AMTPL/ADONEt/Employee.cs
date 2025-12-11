using System;

namespace BridgeLabz_Training_AMTPL.ADONEt
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }

        static void Main(string[] args)
        {
            EmployeeRepo repo = new EmployeeRepo();



            // INSERT
            Employee emp = new Employee
            {
                Id = 1,
                Name = "Ramesh",
                Dept = "IT"
            };

            repo.InsertEmployee(emp);

            // UPDATE
            repo.UpdateEmployee(1, "Ramesh Kumar", "Software");

            // DELETE
            repo.DeleteEmployee(1);

            Console.WriteLine("All operations completed!");
        }
    }
}
