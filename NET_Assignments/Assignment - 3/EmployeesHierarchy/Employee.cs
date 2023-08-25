using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesHierarchy
{
    abstract internal class Employee
    {
        
        public string Name { get; set; }
        public int EmployeeId { get; set; } 
        public double Salary { get; set; }
        public Employee(string name, int employeeId, double salary)
        {
            Name = name;
            EmployeeId = employeeId;
            Salary = salary;
        }
        public virtual void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Name: {Name} EmployeeID: {EmployeeId} Salary: {Salary}");
        }

        abstract public double CalculateBonus();
        
    }

    class Manager : Employee
    {
        public Manager(string name, int employeeId, double salary): base(name, employeeId, salary)
        {
            Name = name;
            EmployeeId = employeeId;
            Salary = salary;
        }

        public override double CalculateBonus()
        {
            return Salary * 0.15;
        }
        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Name: {Name} EmployeeID: {EmployeeId} Salary: {Salary} Bonus: {CalculateBonus()}");
        }
    }

    class Developer : Employee
    {
        public Developer(string name, int employeeId, double salary) : base(name, employeeId, salary)
        {
            Name = name;
            EmployeeId = employeeId;
            Salary = salary;
        }

        public override double CalculateBonus()
        {
            return 2000;
        }
        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Name: {Name} EmployeeID: {EmployeeId} Salary: {Salary} Bonus: {CalculateBonus()}");
        }
    }

    class SalesPerson : Employee
    {
        public SalesPerson(string name, int employeeId, double salary) : base(name, employeeId, salary)
        {
            Name = name;
            EmployeeId = employeeId;
            Salary = salary;
        }
        public override double CalculateBonus()
        {
            return Salary * 0.1;
        }
        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Name: {Name} EmployeeID: {EmployeeId} Salary: {Salary} Bonus: {CalculateBonus()}");
        }
    }
}
