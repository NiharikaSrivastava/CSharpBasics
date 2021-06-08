/*
//Q6. Write code to define a class Point that has:
//a) Two read-only automatic public properties X and Y that return int.
//b) A public constructor that takes two integers x and y as parameters and assigns them to the X
//and Y properties (read-only properties can be assigned values in the constructor).
//c) A public function Deconstruct that returns a tuple containing two integer values of X and Y
using System;
namespace InSem1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value of x co-ordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter value of y co-ordinate: ");
            int y = int.Parse(Console.ReadLine());
            Point pt = new Point(x,y);
            var result = pt.Deconstruct();
            pt.DisplayResult(result);
        }
    }
    class Point
    {
        public readonly int X;
        public readonly int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Tuple<int,int> Deconstruct()
        {
            var tup = Tuple.Create(X, Y);
            return tup;
        }
        public void DisplayResult(Tuple<int,int> tup)
        {
            Console.Write("The elements of the tuple are: ("+tup.Item1+","+tup.Item2+")");
        }
    }
}
*/