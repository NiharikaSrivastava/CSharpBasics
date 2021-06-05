/*using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class Program
    {
        //Private members/methods are accessible only within class
        private static string k = ""; //declared in class scope, access in all nested blocks of this class as well
        static void Main(string[] args)
        {
            //Understanding Scope
            string j=""; //j is declared in scope of Main 
            for(int i=1;i<=5;i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine("i: " + i); //i is accessible here as inside its scope
            }
            //Console.WriteLine("i: " + i); //i is not accessible here as it is outside its scope
            Console.WriteLine("j: " + j);
            Console.WriteLine("k: " + k);
            testAccessibilityMethod();
            //Access Modifiers
            Car myCar = new Car();
            myCar.testPublicMethod();
            //myCar.testPrivateMethod(); //cannot access private method of another class
        }
        static void testAccessibilityMethod()
        {
            Console.WriteLine("k(inside test method): " + k);
        }
    }
    class Car
    {
        public void testPublicMethod()
        {
            Console.WriteLine("Hello, I am Car class's public method");
        }
        private void testPrivateMethod()
        {
            Console.WriteLine("Hello, I am Car class's private method");
        }
        //protected(inheritance) and internal(assembly) access modifiers
    }
}
*/