using System;

class Looper
{

    public Looper()
    {

    }

    public void loop()
    {
        for (int i = 0; i <= 10; i++)
        {

            switch (i)
            {
                case 1:
                    Console.WriteLine($"This is the first number");
                    break;

                case 10:
                    Console.WriteLine($"This is the last number");
                    break;

                default:
                    Console.WriteLine($"{i}");
                    break;
            }
        }
    }

}