/*using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class _6_Methods
    {
        static void Main(string[] args)
        {
            //HelloWorld(); //without parameters
            Console.WriteLine("Name Game\n");
            Console.Write("Enter First Name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter Middle Name: ");
            string mName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("\nOriginal Details: ");
            displayDetails(fName, mName, lName);

            Console.WriteLine("\nReversed Details: ");
            displayDetails(
                ReverseMessage(fName),
                ReverseMessage(mName),
                ReverseMessage(lName)
                );

            Console.WriteLine("\nReversed Details: "); //Function Overloading
            displayDetails(
                ReverseMessage(fName) + " " +
                ReverseMessage(mName) + " " +
                ReverseMessage(lName)
                );
        }
        private static string ReverseMessage(string message)
        {
            char[] charArr = message.ToCharArray();
            Array.Reverse(charArr);
            return String.Concat(charArr); //convert char array back to string
        }

        static void displayDetails(string fName, string mName, string lName)
        {
            Console.WriteLine(String.Format("First Name: {0} \nMiddle Name: {1}\nLast Name:{2}",fName,mName,lName));
        }
        static void displayDetails(string message) //changing no. of parameters, function overloaded
        {
            Console.WriteLine(message);
        }

        private static void HelloWorld() //create inside class but outside Main method
        {
            Console.WriteLine("Hello World");
        }
    }
}
*/