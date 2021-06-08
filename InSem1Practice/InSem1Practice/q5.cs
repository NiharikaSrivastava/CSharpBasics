/*
//Q5. Complete the function AnArray() in the following program. The code in the function should create an
//array. The 1st element of this array should have integer 10 as it’s value, the 2nd element should have
//boolean false as its value, the 3rd element should store reference to a DateTime object (use new
//DateTime(2019, 01, 01) to create the object). And, the 4th element of the array should have string
//“sample string”.
//Write foreach loop in the same function to print the elements of the array.
using System;
using System.Collections;
namespace InSem1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Q5.AnArray();
        }
    }
    class Q5
    {
        internal static void AnArray()
        {
            ArrayList myArr = new ArrayList() { 10, false, new DateTime(2019, 01, 01), "sample string" }; //can't use array as they can store elements of only one data type
            Console.WriteLine("Contents of ArrayList: ");
            foreach (var element in myArr)
                Console.WriteLine(element);
        }
    }
}
*/