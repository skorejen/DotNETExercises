using System.Collections.Generic;

class Company
{

    private List<Employee> _employees;

    public Company()
    {
        this._employees = new List<Employee>();
    }
    public double GetMonthSalaryTotal()
    {
        double total = 0;
        foreach (Employee emp in _employees)
        {
            total += emp.GetMonthSalary();
        }
        return total;
    }

    public void EmployNewEmployee(Employee newEmployee)
    {
        this._employees.Add(newEmployee);
    }
}