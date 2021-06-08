/*
//Q3. Modify the code block below (represented by the comment) so that it will throw error at runtime if data overflow occurs.
using System;
namespace InSem1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter First Number: ");
                int a = int.Parse(Console.ReadLine()); //Enter value greater than 2,147,483,647 such that data overflow for integer datatype occurs
                Console.Write("Enter Second Number: ");
                int b = int.Parse(Console.ReadLine());
                int c = a * b;
                Console.WriteLine("{0} * {1} = {2}",a,b,c);
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Overflow Exception Handled: ");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Handled: ");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Program Execution Continues..");
        }
    }
}
*/