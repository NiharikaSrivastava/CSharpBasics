/*
//Q5. Observe the code below. The class AdvCalc has a list of doubles and few functions that operate on this
//list. The code in ProcessAsync() function is to be made concurrent using Task, async and await.
//You should carefully identify the sequence dependencies between the actions.Eg.See that
//SquarRoot() depends on list to be first sorted because the DisplayResults function assumes
//largeList and sqrts lists are having numbers in correspondence.i.e.first number in largeList has
//its square root as first number in sqrts list, and so on. Re-write Main() and ProcessAsync() functions making necessary changes to introduce maximum
//concurrency in ProcessAsync() using Task, async and await.You should not modify any other code.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EndSemPractice
{
    public class AdvCalc
    {
        List<double> largeList = new List<double>();
        static async Task Main(string[] args)
        {
            await ProcessAsync();
        }
        public static async Task<AdvCalc> ProcessAsync()
        {
            AdvCalc advCalc = new AdvCalc();
            await Task.Run(() => advCalc.PrepareLargeList());
            advCalc.SortInPlace();
            List<double> sqrts = advCalc.SquareRoot();
            double sum = advCalc.SumAll();
            Console.WriteLine("Doing calculations...");
            advCalc.DisplayResults(sqrts, sum);
            return advCalc;
        }
        private void DisplayResults(List<double> sqrts, double sum)
        {
            Console.WriteLine($"Sum = {sum}");
            for (int i = 0; i < largeList.Count; i++)
                Console.WriteLine($"Square root of {largeList[i]} is {sqrts[i]}");
        }
        private double SumAll()
        {
            return largeList.Sum();
        }
        private List<double> SquareRoot()
        {
            List<double> sq = new List<double>();
            largeList.ForEach(f => sq.Add(Math.Sqrt(f)));            
            return sq;
        }
        private void SortInPlace()
        {
            largeList.Sort();
        }
        private void PrepareLargeList()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
                largeList.Add(r.NextDouble() * 1000.0);
        }
    }
}
*/