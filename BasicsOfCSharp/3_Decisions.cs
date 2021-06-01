/*using System;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giveaway Game");
            Console.Write("Choose a box 1/2/3/4/5: ");
            string boxChoice = Console.ReadLine();
            string message;
            if (boxChoice == "2")
                message = "Congratulations, You won an iPhone!";
            else if (boxChoice == "4")
                message = "Congratulations, You won a Car!";
            else
            {
                message = "Sorry, try again next time.";
                message += "\nYou Lose!";
            }
            string message2 = (boxChoice=="2" || boxChoice=="4")?"You selected the Correct Box!": "You selected the Wrong Box!"; //conditional operator
            Console.WriteLine("Hey, {0}\n{1} See you Later, Bye.",message,message2); //input parameter substitution
        }
    }
}
*/