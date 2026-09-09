namespace Odd_Even;
internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        // Call the method and store the returned result
        bool result = IsEven(number);

        if (result)
        {
            Console.WriteLine($"{number} is an Even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an Odd number.");
        }
    }

    // Method that returns true if even, false if odd
    bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}