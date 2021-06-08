/*
//Q4. Re-write the following code replacing the type declaration(s) with var keyword such that the program continues to compile without errors.
using System;
namespace InSem1Practice
{
    class Program
    { 
        static void Main(string[] args)
        {
            KnowVar obj = new KnowVar();
            obj._m = 10;
            obj.MyMethod(obj._m);
        }
    }
    class KnowVar
    {
        public int _m{ get; set; }
        public void MyMethod(int i, int j = 10)
        {
            int k = i + j;
            string sum = "The sum";
            int n;
            string mul;
            n = i * j;
            mul = "The multiplication";
            var ob = new Program();
            KnowVar ob2 = null;
            Console.WriteLine(sum + ": "+ k);
            Console.WriteLine(mul + ": " + n);
        }
    }
    //class KnowVar //original code
    //{
    //    int _m = 10;
    //    public void MyMethod(int i, int j = 10)
    //    {
    //        int k = i + j;
    //        string sum = "The sum";
    //        int n;
    //        string mul;
    //        n = i * j;
    //        mul = "The multiplication";
    //        KnowVar ob = new Program();
    //        KnowVar ob2 = null;
    //    }
    //}
}
*/
