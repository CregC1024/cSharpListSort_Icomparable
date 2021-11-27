using System;
using System.Collections.Generic;

var employees = new List<Employee>
{
    new Employee("John Doe", 1230),
    new Employee("Adam Novak", 670),
    new Employee("Robin Brown", 2300),
    new Employee("Rowan Cruise", 990),
    new Employee("Joe Draker", 1190),
    new Employee("Janet Doe", 980),
    new Employee("Lucy Smith", 980),
    new Employee("Thomas Moore", 1400)
};

employees.Sort();

Console.WriteLine(string.Join(Environment.NewLine, employees));

record Employee(string Name, int Salary) : IComparable<Employee>
{
    public int CompareTo(Employee other)
    {
        return other.Salary.CompareTo(this.Salary);
    }
};
