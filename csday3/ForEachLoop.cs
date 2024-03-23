using System;
class ForEachLoop
{
    public static void Main()
    {
        int[] numbers = new int[]{1,2,3,4,5};
       
        for (int i = 0; i < numbers.Length; i++)
        {
                 Console.WriteLine(numbers[i]);
            numbers[i]=numbers[i]+1;
       
        }

         foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

    }
}
