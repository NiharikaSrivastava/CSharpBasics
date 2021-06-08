/*
//Q2. What is the output of following program (assume it works).
using System;
namespace InSem1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello world";
            s.Replace('o', 'i');
            s.Replace("r", string.Empty);
            Console.WriteLine(s);
        }
    }
}
//Output -> hello world (As the resultant string from Replace methods were not stored in s again)
//helli wild (would have been the output if s=s.Replace('o','i') and s=s.Replace("r",string.Empty) would have been written)
*/