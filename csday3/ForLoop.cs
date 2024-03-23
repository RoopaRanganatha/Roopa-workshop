using System;
class ForLoop
{
    public static void Main()
{
    Console.WriteLine("enter number for star pattern");
    int num = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=num;i++)
{
    for(int j=1; j<=i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
}}
