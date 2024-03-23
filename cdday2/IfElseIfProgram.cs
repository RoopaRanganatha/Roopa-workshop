using System;
// Largest Number
class LargestNumber
{
    public static void Main()
    {
        Console.WriteLine("Enter the First Number");
        int Num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second Number");
        int Num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Third Number");
        int Num3 = Convert.ToInt32(Console.ReadLine());

        if (Num1 > Num2 && Num1 > Num3)
        {
            Console.WriteLine($"Larget Number is {Num1}");
        }
        else if (Num2 > Num3)
        {
            Console.WriteLine($"Larget Number is {Num2}");
        }
        else
        {
            Console.WriteLine($"Larget Number is {Num3}");
        }
    }
}