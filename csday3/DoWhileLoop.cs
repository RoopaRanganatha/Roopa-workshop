using System;
class DoWhileLoop
{
    public static void Main()
    {
        string y = "n";
        do
        {
            int num1,num2 =0;
            Console.WriteLine(" Simple Calculator ");
            Console.WriteLine("Choose \n 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division");
            int ac = Convert.ToInt32(Console.ReadLine());      
            Console.WriteLine("Please enter First Number \n");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Second Number \n");
            num2 = Convert.ToInt32(Console.ReadLine());
            int Res = 0;
            switch (ac)
            {
                case 1:
                    Res = num1 + num2;
                    Console.WriteLine($"Sum is {Res}");
                    break;
                case 2:
                    Res = num1 - num2;
                    Console.WriteLine($"Difference is {Res}");
                     break;
                case 3:
                    Res = num1 * num2;
                    Console.WriteLine($"Product is {Res}");
                     break;
                case 4:
                    Res = num1 / num2;
                    Console.WriteLine($"Dividend is {Res}");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Do you want to Continue? y/n");
            y = Console.ReadLine();
        } while (y=="y");
             Console.WriteLine("Exit!");
    }
}