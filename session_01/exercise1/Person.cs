
using System;

class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name;
    }



    public void Introduce()
    {
        Console.WriteLine($"Hi, I am {this.name}");
    }
}