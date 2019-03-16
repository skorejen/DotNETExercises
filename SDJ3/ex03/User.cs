class User
{
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private string DateOfBirth { get; set; }

    private string[] hobbies { get; set; }


    public override string ToString()
    {


        string st = $"This is a user you got from the client {FirstName} {LastName} {DateOfBirth} with hobbies ";

        foreach (string h in hobbies)
        {
            st += $"{h} \n";
        }
        return st;

    }
}