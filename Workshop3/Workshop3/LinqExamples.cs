using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3
{
    internal class LinqExamples
    {
        public static void Main(string[] args)
        {
       
        List<Exmployee>employeeList= new List<Exmployee>();
            employeeList.Add(new Exmployee(1, "Prasanna", new DateOnly(2003, 4, 15), new DateTime(2025, 4, 15),"IT",30000));
            employeeList.Add(new Exmployee(2, "Pramodh", new DateOnly(2002, 7, 15), new DateTime(2021, 4, 12), "HR",23000));
            employeeList.Add(new Exmployee(3, "Muttu", new DateOnly(2002, 7, 15), new DateTime(2022, 4, 12), "HR",120000));
            employeeList.Add(new Exmployee(4, "Cheatha", new DateOnly(2007, 7, 15), new DateTime(2021, 4, 12), "Finance",12444));
            employeeList.Add(new Exmployee(5, "Nive", new DateOnly(2005, 3, 15), new DateTime(2022, 4, 12), "IT",23444));


            var selectEmpSalaryGrether240000 = employeeList.Where(x => x.Salary > 24000).ToList();
            Console.WriteLine("Employee List Based on  salary");
            foreach ( var employee in selectEmpSalaryGrether240000)
            Console.WriteLine( employee );

            Console.WriteLine("Employee Name to Upper Case");
            var converToUpper = employeeList.Select(name => name.Name.ToUpper());
            foreach (var employee in converToUpper)
                Console.WriteLine(employee);

            var filterBasedOnLengthOfName = employeeList.Find(x=>x.Equals("Prasanna"));
            Console.WriteLine(filterBasedOnLengthOfName);

            var groupByBasedOnYearOfJoining = employeeList.GroupBy(x => new
            {
                Year = x.JoingDate.Year,
                Month = x.JoingDate.Month
            });


            Console.WriteLine("Group based on Year and month");
            foreach(var  x in groupByBasedOnYearOfJoining)
            {
                Console.WriteLine($"Year: {x.Key.Year}, Month: {x.Key.Month}");
                foreach (var emp in x)
                {
                    Console.WriteLine($"   {emp.Name} joined on {emp.JoingDate}");
                }
            }

            Console.WriteLine(" Sort Based on Date find Younges employee");
            var youngesEmp = employeeList.OrderByDescending(date => date.DateOfBirth).FirstOrDefault().Id;
                ;
            Console.WriteLine("Yonges emp Id  "+ youngesEmp);

           String empName= employeeList.Find(e=>e.Id==4).Name;
            Console.WriteLine(empName);
               

          IEnumerable<Exmployee>empReverse=employeeList.AsEnumerable().Reverse();
             Console.WriteLine("Reverse");
            foreach(var emp in empReverse)
            {
                Console.WriteLine(emp.Name +"  "+emp.Department);
            }
            Console.WriteLine("Write emp names  who joined between 2022 and 2025");
            IEnumerable<Exmployee> sortEmployees = employeeList
                                                   .Where(e => e.JoingDate.Year >= 2022 && e.JoingDate.Year <= 2025);
            foreach (var emp in sortEmployees)
            {
                Console.WriteLine(emp.Name + " " + emp.Department);
            }
            var experienceMonths = employeeList.Select(e => new
            {
                e.Id,
                e.Name,
                Experience = ((DateTime.Now.Year - e.JoingDate.Year)),
                Months = (DateTime.Now.Month - e.JoingDate.Month) 
            });
            foreach (var experience in experienceMonths)
            {
                Console.WriteLine("Experience in months " + experience);
            }
            List<List<int>> numbers = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5 },
    new List<int> { 6, 7, 8 }
};

            var flatList = numbers.SelectMany(n => n);

            foreach (var num in flatList)
            {
                Console.WriteLine(num);
            }
             int sum=flatList.Sum();
             Console.WriteLine(sum);
            double avg=flatList.Average();
            Console.WriteLine(avg);
            Console.WriteLine(flatList.Max());
        }
    }
}
