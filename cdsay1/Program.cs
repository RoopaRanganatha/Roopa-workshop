using System;
/*using System;

namespace cdsay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}*/
/*
// Program to add 2 Number
using System;
int num1, num2;

Console.WriteLine("Please ENTER first NUMBER ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please ENTER second NUMBER ");
num2 = Convert.ToInt32(Console.ReadLine());

int sum = num1+num2;
Console.WriteLine("Sum : "+sum);


// Program to SWAP Two Number values

int num1, num2;

Console.WriteLine("Please ENTER first NUMBER ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please ENTER second NUMBER ");
num2 = Convert.ToInt32(Console.ReadLine());
int temp = num1;
num1 = num2;
num2 = temp;
Console.WriteLine("Number1 :"+num1+" & "+"Number2 :"+num2);


// Program to SWAP Two Number values without using temp

int num1, num2;

Console.WriteLine("Please ENTER first NUMBER ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please ENTER second NUMBER ");
num2 = Convert.ToInt32(Console.ReadLine());

num1 = num1+num2;
num2 = num1-num2;
num1 =num1-num2;
Console.WriteLine("Number1 :"+num1+" & "+"Number2 :"+num2);


// Program to Write the tabble of a Number 

int num;
Console.WriteLine("Enter the Number for Table");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} x 1 = {num*1}");
Console.WriteLine($"{num} x 2 = {num*2}");
Console.WriteLine($"{num} x 3 = {num*3}");
Console.WriteLine($"{num} x 4 = {num*4}");
Console.WriteLine($"{num} x 5 = {num*5}");
Console.WriteLine($"{num} x 6 = {num*6}");
Console.WriteLine($"{num} x 7 = {num*7}");
Console.WriteLine($"{num} x 8 = {num*8}");
Console.WriteLine($"{num} x 9 = {num*9}");
Console.WriteLine($"{num} x 10 = {num*10}");

// Program to find the sum of the digits
// 3405 sum 21

// a=3405/1000=3
// b=(3405%1000)/100=4
// c=(3405%100)/10=0
// d=3405%10

int num;
Console.WriteLine("Enter the number to find the sum of the digits");
num = Convert.ToInt32(Console.ReadLine());
int a,b,c,d;
a=num/1000;
b=(num%1000)/100;
c=(num%100)/10;
d=num%10;
Console.WriteLine($"Digits in {num} are {a}{b}{c}{d} and sum is {a+b+c+d}");

*/
int num;
Console.WriteLine("Enter the number to find the sum of the digits");
num = Convert.ToInt32(Console.ReadLine());
int sum=0;
sum= sum +num%10;
num=num/10;
sum= sum +num%10;
num=num/10;
sum= sum +num%10;
num=num/10;
sum= sum +num%10;
Console.WriteLine($"sum is {sum}");



