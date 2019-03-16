interface IStudent
{
    void Register(int year);
}

class PartTimeStudent : IStudent
{
    private int _regYear;
    public void Register(int year)
    {
        this._regYear = year;
    }
}