namespace Programming_1_Assignments;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start ()
    {
        Console.WriteLine("Hi! Please enter your age");
        string input = Console.ReadLine();
        int age = int.Parse(input);
    
    // read user's age

    if (age >= 18)
    {
        Console.Write($"You are {age} years old. Access Granted");
    }
    else
    {
        Console.Write($"You need to be at least 18. Denied");
    }
}
}
