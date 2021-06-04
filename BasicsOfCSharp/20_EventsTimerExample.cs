/*using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(1000); //value passed inside in milliseconds
            myTimer.Elapsed += MyTimer_Elapsed_Handler1; //ATTACHING EVENT HANDLER -> Elapsed is the Event, MyTimer_Elapsed_Handler1 is the method which specifies the actions to be executed when event occurs
            myTimer.Elapsed += MyTimer_Elapsed_Handler2; //attaching more than one handler
            myTimer.Start();
            Console.WriteLine("Press Enter to remove the Blue Event..");
            Console.ReadLine(); //continues until user presses enter
            myTimer.Elapsed -= MyTimer_Elapsed_Handler2; //DETACHING EVENT HANDLER
            Console.ReadLine();
        }

        private static void MyTimer_Elapsed_Handler1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elapsed: {0:HH:mm:ss:ff}",e.SignalTime);
        }
        private static void MyTimer_Elapsed_Handler2(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Elapsed: {0:HH:mm:ss:ff}", e.SignalTime);
        }
    }
}
*/