using EmployeeManagementSystem;
using System;

public class Employee
{
    private int _id;
    private string _name;
    private string _email;
    private double _salary;

    public int Id
    {
        get { return _id; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Id must be greater than zero.");
            _id = value;
        }
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            _name = value;
        }
    }

    public string Email
    {
        get { return _email; }
        set
        {
            if (!EmailValidation.IsValidEmail(value))
                throw new EmailValidation("Invalid email format.");
            _email = value;
        }
    }

    public double Salary
    {
        get { return _salary; }
        set
        {
            if (value <= 0)
                throw new SalaryExeception("Salary must be greater than zero.");
            _salary = value;
        }
    }

    public Employee(int id, string name, string email, double salary)
    {
       
        if (id <= 0)
            throw new ArgumentException("Id must be greater than zero.");

   
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.", nameof(name));

 
        if (!EmailValidation.IsValidEmail(email))
            throw new EmailValidation("Invalid email format.");

        if (salary <= 0)
            throw new SalaryExeception("Salary must be greater than zero.");
        Id = id;
        Name = name;
        Email = email;
        Salary = salary;
    }



    public override bool Equals(object obj)
    {
        return obj is Employee employee && _id == employee._id;
    }

   
    public override int GetHashCode()
    {
        return _id.GetHashCode();
    }

    public override string ToString()
    {
        return $"Employee [Id={Id}, Name={Name}, Email={Email}, Salary={Salary}]";
    }
}