using System;
// Largest Number
class LetterCheck
{
    public static void Main()
    {
        Console.WriteLine("Enter the Alphabet");
        char letter = (char)Console.Read();

        switch (letter)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Constant");
                break;
        }
    }
}