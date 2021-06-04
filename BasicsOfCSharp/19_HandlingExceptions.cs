/*using System;
using System.Collections.Generic;
using System.IO;

namespace BasicsOfCSharp
{
    class Program //Handling Runtime Exceptions
    {
        static void Main(string[] args)
        {
            //FileNotFoundException
            try //error prone code in try block, must be followed by catch block, multiple catch blocks allowed
            {
                string content = File.ReadAllText(@"C:\Users\zoomp\Desktop\Niharika DAIICT study material\Summer Internship\C# Learning Youtube\BasicsOfCSharp\webScrap.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex) //from most specific to genral catch
            {
                Console.WriteLine("Exception Handled (FileNotFound):\n" + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Exception Handled (DirectoryNotFound):\n" + ex.Message);
            }
            catch (Exception ex) //Exception (Most genric type, used for all types of exceptions)
            {
                Console.WriteLine("Exception Handled:\n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nInside finally block!"); //exceuted always, wheteher exception occurs or not (Code to finalize, set objects to null, close database connections)
            }
            Console.WriteLine("\nProgram Execution Continues..");
        }
    }
}
*/