using System;
class Animal : IComparable


{
    private string _type;
    private double _weight;
    private int _speed;

    public double Weight { get; }
    public int Speed { get; }
    public Animal(string type, double weight, int speed)
    {
        this._speed = speed;
        this._type = type;
        this._weight = weight;
    }

    public int CompareTo(object obj)
    {
        Animal animal = (Animal)obj;

        if (this._weight < animal.GetWeight())
        {
            return -1;
        }
        else if (this._weight > animal.GetWeight())
        {
            return 1;
        }
        else
        {
            return 0;
        }


    }
    public double GetWeight()
    {
        return this._weight;
    }
    public int GetSpeed()
    {
        return this._speed;
    }

    public override string ToString()
    {
        return $"The animal type is {_type}, its weight is {_weight} and its speed is {_speed}";
    }


}