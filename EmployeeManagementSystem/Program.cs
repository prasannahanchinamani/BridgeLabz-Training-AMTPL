using EmployeeManagementSystem;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Employee Management System");

        IEmployeeService employeeService = new EmployeeService();

        while (true)
        {
            Console.WriteLine("\nEnter Choice:");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Update Employee");
            Console.WriteLine("3. Delete Employee");
            Console.WriteLine("4. Display Employees");
            Console.WriteLine("5. Exit");

            int choice = Validator.ReadId("Enter Choice:"); 

            switch (choice)
            {
                case 1:
                    Employee emp1 = Menu();
                    employeeService.AddEmployee(emp1);
                    Console.WriteLine("Employee added successfully!");
                    break;

                case 2:
                    int id = Validator.ReadId("Enter Id to update:"); 
                    string name = Validator.ReadName("Enter Name:");
                    string email = Validator.ReadEmail("Enter Email:");
                    double salary = Validator.ReadSalary("Enter Salary:"); 
                    employeeService.UpdateEmployee(id, name, email, salary);
                    Console.WriteLine("Employee updated successfully!");
                    break;

                case 3:
                    int deleteId = Validator.ReadId("Enter Id to delete:"); 
                    employeeService.DeleteEmployee(deleteId);
                    Console.WriteLine("Employee deleted successfully!");
                    break;

                case 4:
                    employeeService.DisplayEmployees();
                    break;

                case 5:
                    Console.WriteLine("Thank You.");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static Employee Menu()
    {
        int id = Validator.ReadId("Enter Employee Id:"); 
        string name = Validator.ReadName("Enter Employee Name:");
        string email = Validator.ReadEmail("Enter Employee Email:");
        double salary = Validator.ReadSalary("Enter Employee Salary:"); 

        return new Employee(id, name, email, salary);
    }
}