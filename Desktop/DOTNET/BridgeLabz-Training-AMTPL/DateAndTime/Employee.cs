using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.DateAndTime
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime JoingDate { get; set; }
        public Employee(int id, string name, string department, DateTime dateOfBirth, DateTime joingDate)
        {
            Id = id;
            Name = name;
            Department = department;
            DateOfBirth = dateOfBirth;
            JoingDate = joingDate;
        }
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee(1, "Prasanna", "CSE", new DateTime(2000, 12, 3), new DateTime(2025, 1, 1)));
            list.Add(new Employee(2, "Ravi", "ECE", new DateTime(1999, 5, 15), new DateTime(2024, 6, 10)));
            list.Add(new Employee(3, "Sneha", "IT", new DateTime(2001, 8, 20), new DateTime(2025, 2, 5)));
            list.Add(new Employee(4, "Anita", "HR", new DateTime(1998, 3, 12), new DateTime(2023, 7, 1)));
            list.Add(new Employee(5, "Kiran", "Finance", new DateTime(1997, 11, 25), new DateTime(2022, 9, 15)));
            list.Add(new Employee(6, "Meena", "ADAT", new DateTime(2002, 4, 10), new DateTime(2025, 3, 20)));
            list.Add(new Employee(7, "Arjun", "IT", new DateTime(1996, 6, 5), new DateTime(2021, 12, 1)));
            list.Add(new Employee(8, "Divya", "HR", new DateTime(2000, 1, 30), new DateTime(2024, 11, 10)));
            DateTime today = DateTime.Today;

            Console.WriteLine("\n=== Employees Who Joined This Year ===");
            var joinedThisYear = list.Where(e => e.JoingDate.Year == today.Year).ToList();
            joinedThisYear.ForEach(e => Console.WriteLine($"{e.Name} | {e.JoingDate:dd-MM-yyyy}"));
            // Employees who have a birthday this month
            var BirthdayMonth = list.Where(e => e.JoingDate.Month == today.Month).ToList();
            BirthdayMonth.ForEach(e => Console.WriteLine($"{e.Name}|{e.Department}|{e.JoingDate}"));
            // 3️⃣ Sort by DateOfBirth (youngest first)
            var youngestEmp = list.OrderByDescending(e => e.DateOfBirth).ToList();
            Console.WriteLine("\n=== Youngest Employees First ===");
            youngestEmp.ForEach(e => Console.WriteLine($"{e.Name} | DOB: {e.DateOfBirth:dd-MM-yyyy}"));

            var groupByDepartment = list.GroupBy(e => e.Department);
            foreach (var group in groupByDepartment)
            {
                Console.WriteLine(group.Key);
                foreach (var emp in group)
                {
                    Console.WriteLine($"{emp.Name}");
                }
            }
            Console.WriteLine("\n=== Group by Joining Year ===");
            var joiningYear = list.GroupBy(e => e.JoingDate.Year).OrderBy(e => e.Key);
            foreach (var emp in joiningYear)
            {
                Console.WriteLine(emp.Key);
                foreach (var x in emp)
                {
                    Console.WriteLine($"{x.Name},Joing Date: {x.JoingDate}");
                }
            }



            Console.WriteLine("=== Age & Experience ===");
            var ageAndExperience = list.Select(e => new
            {
                e.Name,
                age = (today.Year - e.DateOfBirth.Year) -
                      ((today.Month < e.DateOfBirth.Month || ((today.Month == e.DateOfBirth.Month) && today.Date < e.DateOfBirth.Date)) ? 1 : 0),

               Experience = (today.Year - e.JoingDate.Year) -
                            ((today.Month < e.JoingDate.Month ||
                             (today.Month == e.JoingDate.Month && today.Day < e.JoingDate.Day)) ? 1 : 0)

            });


            foreach (var item in ageAndExperience)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.age}, Experience: {item.Experience}");
            }
        }
    }
}
