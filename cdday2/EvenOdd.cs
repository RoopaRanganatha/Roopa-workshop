using System;
//If else example
class IfElseProgram
{
    public static void Main()
    {

        Console.WriteLine("Enter the number");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
            Console.WriteLine($"Number {num} is even");
        else
            Console.WriteLine($"Number {num} is Odd");
        Console.WriteLine("Exit");

    }
}