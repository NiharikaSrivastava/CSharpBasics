/*using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num = new int[] {1,2,3,4,5};
            int[] numbers = new int[5];
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i] = i + 1;
                Console.WriteLine("Index {0}:{1}", i, numbers[i]);
            }
            Console.ReadLine();

            string[] names = new string[] {"Niharika Srivastava", "Suhani Sharma", "Archana Arora"};
            foreach(string n in names) //enhanced for loop
            {
                Console.WriteLine("Name: "+n);
            }
            Console.ReadLine();

            //Reverse string by converting it to character array
            string myStr= "Let's learn C Sharp!";
            Console.WriteLine("Original String: "+myStr);
            char[] charArr = myStr.ToCharArray(); //convert string to char array
            Array.Reverse(charArr); //reversing char array
            Console.Write("Reverse String: ");
            foreach(char c in charArr)
            {
                Console.Write(c);
            }
        }
    }
}
*/