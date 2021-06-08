/*
//Q1. The code written in Main() function below outputs the following output. Complete the following code
//including the definition of class which will result in this output (without hardcoding the values).
using System;
namespace InSem1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int b = int.Parse(Console.ReadLine());
            int sum = Calculator.AddNums(a, b);
            string output = sum.ToString();
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, output);
        }
    }
    class Calculator
    {
        internal static int AddNums(int a, int b)
        {
           return a+b;
        }
    }
}
*/