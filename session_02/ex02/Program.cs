using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new PartTimeEmployee("Jhon", 15, 50);
            Employee emp2 = new PartTimeEmployee("Tom", 20, 50);
            Employee emp3 = new PartTimeEmployee("Jhon", 10, 70);
            Employee emp4 = new PartTimeEmployee("Arill", 90, 40);
            Employee emp5 = new FullTimeEmployee("Adam", 2500);

            Company company = new Company();
            company.EmployNewEmployee(emp1);
            company.EmployNewEmployee(emp2);
            company.EmployNewEmployee(emp3);
            company.EmployNewEmployee(emp4);
            company.EmployNewEmployee(emp5);
            System.Console.WriteLine(company.GetMonthSalaryTotal());

        }
    }
}
