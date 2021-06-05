/*using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while(showMenu)  //display Menu and perform operations until we wish to exit
            {
                Console.Clear(); //to clear the console
                showMenu=displayMenu();
            }
            Console.WriteLine("See you Later! Bye!");
        }
        private static bool displayMenu()
        {
            Console.Write("\n***** Game's Corner *****\n"
                +"1. Calculate Factorial\n"
                +"2. Guessing Game\n"
                +"3. Exit\n"
                +"Enter Your Choice: "
                );
            string choice = Console.ReadLine(); //As we read from console, always string returned
            if (choice == "1")
                calcFactorial();
            else if (choice == "2")
                guessingGame();
            else if (choice == "3")
                return false; // only when user selects exit
            else
                Console.WriteLine("Please Enter Choice as 1/2/3 Only.");
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
            return true;
        }
        private static void calcFactorial()
        {
            Console.Write("Calculating Factorial...\n"+"Enter Number to find its factorial: ");
            int num = int.Parse(Console.ReadLine()); //Explicit Type Casting by using Parse Method
            int counter=1, fact=1;
            while (counter <= num)
            {
                fact = fact * counter;
                counter++;
            }
            Console.WriteLine("Factorial of {0}: {1}",num,fact);
        }
        private static void guessingGame()
        {
            Console.WriteLine("Guessing Game...");
            Random randObj = new Random(); //Random is a separate class in C Sharp
            int randNumber = randObj.Next(1,11); //Next(start, end+1); as end is exclusive so rand number from 1 to 10 generated
            int guesses = 0;
            bool incorrect = true; 
            string inputNum;
            do
            {
                Console.Write("Enter your guess from 1 to 10: ");
                inputNum = Console.ReadLine();
                guesses++;
                if(inputNum== randNumber.ToString())
                {
                    Console.WriteLine("Correct Guess!");
                    incorrect = false;
                }
                Console.WriteLine("Wrong.. Keep Guessing!");
            } while (incorrect);
            Console.WriteLine("You guessed the correct number {0} in {1} Guesses!",randNumber,guesses);
        }
    }
}
*/