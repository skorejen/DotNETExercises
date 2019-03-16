class Student
{
    public virtual void Hi()
    {
        System.Console.WriteLine("Hi I am student");
    }
}

class DNPStudent : Student
{
    new public void Hi()
    {
        base.Hi();
        System.Console.WriteLine("Hi I am a DNP student");
    }
}