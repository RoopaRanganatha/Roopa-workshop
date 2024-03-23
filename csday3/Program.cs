using System;
class WhileLoop
{
    public static void Main()
    {
        Console.WriteLine("Enter the Number");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (num > 0)//Check condition
        {
            int ld = num % 10;
            sum = sum + ld;
            // update
            num = num / 10;
        }
        Console.WriteLine($"Sum is {sum}");
    }
}



// namespace csday3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter the year");
//             int yr = Convert.ToInt32(Console.ReadLine());
//             if(yr%400==0 || (yr%4==0 && yr%100!=0))
//             {
//                 Console.WriteLine("LeapYear");
//             }
//             else
//             Console.WriteLine(" Not a LeapYear");
//         }
//     }
// }