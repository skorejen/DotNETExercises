using System;

namespace examples
{
    class Program
    {
       static void Main(string[] args)
{
     Program program = new Program();
    Console.WriteLine("BAH");
    int y = Convert.ToInt16(Console.ReadLine());
    program.Out(y);
}

public void Out(int value)
{
    Console.WriteLine(value);
}
    }
}
