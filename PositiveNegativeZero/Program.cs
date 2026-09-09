namespace PositiveNegativeZero;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
    void Start()
    {
        Console.WriteLine("Enter a number ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        if (number > 0)
        {
            Console.Write($"Your number is {number}, that is a positive number");
        }
        else if (number == 0)
        {
            Console.Write($"You entered a zero number");
        }
        else
        {
            Console.Write($"Your number is {number}, that is a negative number");
        }
    }
}
