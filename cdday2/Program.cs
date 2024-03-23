using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //If example
        Console.WriteLine("Enter the number");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
            Console.WriteLine("Number is grater than zero");
        Console.WriteLine("Exit");
    }
}