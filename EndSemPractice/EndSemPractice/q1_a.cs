//Q1. a. What is the output of the following function when called from Main()?
/*using System;
using System.Linq;
namespace EndSemPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryOverInts();
        }
        static void QueryOverInts()
        {
            int[] numbers = { 20, 80, 10, 50, 30, 60, 40, 70, 90 };
            var less = numbers.Where(n => n > numbers[2]).Select(n => n); //less={20,80,50,30,60,40,70,90}
            var intFactor = numbers.Select(n => n / numbers.Min()).ToArray(); //numbers.Min()=10, intFactor={2,8,1,5,3,6,4,7,9}
            numbers[2] = 40; //numbers = {20,80,40,50,30,60,40,70,90}
            foreach (var i in less) //less changes as numbers changed, less={80,50,60,70,90}
                Console.Write("{0} ", i);
            Console.WriteLine();
            Console.WriteLine("{0}", intFactor.Sum()); //45
        }
    }
}

//Output: 
//80 50 60 70 90
//45
*/