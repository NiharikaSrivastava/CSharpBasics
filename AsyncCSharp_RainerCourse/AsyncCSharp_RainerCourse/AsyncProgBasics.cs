using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncCSharp_RainerStropekCourse
{
    class AsyncProgBasics
    {
        static async Task Main(string[] args)
        {
            //File.WriteAllText(@"C:\Users\zoomp\Desktop\Niharika DAIICT study material\Summer Internship\test1.txt", "hello world");  //Synchronous Version of method
            //File.WriteAllTextAsync(@"C:\Users\zoomp\Desktop\Niharika DAIICT study material\Summer Internship\test1.txt", "hello world"); //Asynchronous Version of method
            var lines = File.ReadAllLines(@"C:\Users\zoomp\Desktop\Niharika DAIICT study material\Summer Internship\C# Learning Youtube\CSharpCodePractice\AsyncCSharp_RainerCourse\AsyncCSharp_RainerCourse\file1.txt"); //returns string array
            Console.WriteLine("Synchronous Approach - Content of file: \n");
            foreach (var line in lines)
                Console.WriteLine(line);
            Console.WriteLine("\nAsynchronous Old Approach - Content of file: \n");
            //returns Task of string array
            var fileReadTask = File.ReadAllLinesAsync(@"C:\Users\zoomp\Desktop\Niharika DAIICT study material\Summer Internship\C# Learning Youtube\CSharpCodePractice\AsyncCSharp_RainerCourse\AsyncCSharp_RainerCourse\file1.txt")
                .ContinueWith(t=>
                {
                    //Code to be executed once the Task is completed
                    if(t.IsFaulted)
                    {
                        Console.Error.WriteLine(t.Exception);
                        return;
                    }
                    foreach(var line in t.Result)
                        Console.WriteLine(line);
                });
            Console.ReadKey();
            //Console.WriteLine("Status: "+fileReadTask.Status); //WaitingForActivation
            //Thread.Sleep(1000);
            //fileReadTask.Wait();//blocking call
            //Console.WriteLine("Status: " + fileReadTask.Status); //RanToCompletion

            Console.WriteLine("\nAsynchronous New Approach (aync+await) - Content of file: \n");
            
            await GetContentOfFile();
            int networkResult = await GetDataFromNetwork();

            Func<Task<int>> GetDataFromNetworkLambda = async () =>
            {
                //Simulate Network Call by using Lambda Expression
                await Task.Delay(1000);
                int result = 42;
                return result;
            };
        }
        static async Task GetContentOfFile()
        {
            var lines = await File.ReadAllLinesAsync(@"C:\Users\zoomp\Desktop\Niharika DAIICT study material\Summer Internship\C# Learning Youtube\CSharpCodePractice\AsyncCSharp_RainerCourse\AsyncCSharp_RainerCourse\file1.txt"); //returns string array
            foreach (var line in lines)
                Console.WriteLine(line);
        }
        static async Task<int> GetDataFromNetwork()
        {
            //Simulate Network Call
            await Task.Delay(1000);
            int result = 42;
            return result;
        }
    }
}
