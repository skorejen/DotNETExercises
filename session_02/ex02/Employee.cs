abstract class Employee
{
    private string _name;

    public abstract double GetMonthSalary();
    public Employee(string name)
    {
        this._name = name;
    }
}

class FullTimeEmployee : Employee
{

    private double _monthSalary;

    public FullTimeEmployee(string name, double monthSalary) : base(name)
    {
        this._monthSalary = monthSalary;
    }
    public override double GetMonthSalary()
    {
        return _monthSalary;
    }
}

class PartTimeEmployee : Employee
{
    private double _hourlyWage;
    private int _hoursPerMonth;
    public PartTimeEmployee(string name, double hourlyWage, int hoursPerMonth) : base(name)
    {
        this._hourlyWage = hourlyWage;
        this._hoursPerMonth = hoursPerMonth;
    }

    public override double GetMonthSalary()
    {
        return _hourlyWage * _hoursPerMonth;
    }
}