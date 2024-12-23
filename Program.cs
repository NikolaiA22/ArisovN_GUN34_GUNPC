using System;

class Program
{
    static void Main()
    {
        int a, b;

        Console.WriteLine("First num:");
        if (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Error!");
            return;
        }

        Console.WriteLine("Second num:");
        if (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Error!");
            return;
        }

        Console.WriteLine("Enter operator (&, |, ^):");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int result;
        switch (operation)
        {
            case '&':
                result = a & b;
                break;
            case '|':
                result = a | b;
                break;
            case '^':
                result = a ^ b;
                break;
            default:
                Console.WriteLine("Error!");
                return;
        }

        Console.WriteLine($"Result in decimal: {result}");
        Console.WriteLine($"Result in binary: {Convert.ToString(result, 2)}");
        Console.WriteLine($"Result in hexadecimal: {Convert.ToString(result, 16).ToUpper()}");
    }
}
