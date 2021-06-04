/*using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo{Description="Task 1", EstimatedHours=6, Status=Status.Completed},
                new Todo{Description="Task 2", EstimatedHours=10, Status=Status.Deleted},
                new Todo{Description="Task 3", EstimatedHours=9, Status=Status.InProgress},
                new Todo{Description="Task 4", EstimatedHours=3, Status=Status.NotStarted},
                new Todo{Description="Task 5", EstimatedHours=12, Status=Status.OnHold},
                new Todo{Description="Task 6", EstimatedHours=7, Status=Status.Completed},
                new Todo{Description="Task 7", EstimatedHours=3, Status=Status.NotStarted},
                new Todo{Description="Task 8", EstimatedHours=8, Status=Status.OnHold},
                new Todo{Description="Task 9", EstimatedHours=10, Status=Status.Completed},
                new Todo{Description="Task 10", EstimatedHours=2, Status=Status.InProgress},
            };
            PrintAssessment(todos);
        }
        public static void PrintAssessment(List<Todo> todos)
        {
            foreach (var t in todos)
            {
                switch (t.Status)
                {
                    case Status.NotStarted:
                        {
                            Console.ForegroundColor = ConsoleColor.Red; //changes text color of output on console, also uses enum  
                            break;
                        }
                    case Status.InProgress:
                        {
                            Console.ForegroundColor = ConsoleColor.Blue; 
                            break;
                        }
                    case Status.OnHold:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed; 
                            break;
                        }
                    case Status.Completed:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        }
                    case Status.Deleted:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Todo Description");
                            return;
                        }
                }
                t.displayTodoDetails();
            }
        }
    }
    class Todo
    {
        public string Description;
        public int EstimatedHours;
        public Status Status;  
        public void displayTodoDetails()
        {
            Console.WriteLine("\n***** Todo Details *****");
            Console.WriteLine("Description: "+Description);
            Console.WriteLine("Estimated Hours: " + EstimatedHours);
            Console.WriteLine("Status: " + Status);
        }
    }
    enum Status //enum type (Limiting the values that a variable can posess to ensure its validity in our system)
    {
        NotStarted, //has numeric value 0 internally
        InProgress, //1 
        OnHold, //2
        Completed, //3
        Deleted //4
    }
}*/