/*using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using escape sequences
            string myStr = "\\This string uses \"escaped characters\"\\";
            Console.WriteLine(myStr);
            
            //New Line Character
            myStr = "Line 1\nLine 2";
            Console.WriteLine(myStr);

            //Using @ to directly display back-slash character
            myStr = @"\This string uses escaped characters\";
            Console.WriteLine(myStr);

            //String.Format function with parameters (for replacement code)
            myStr = String.Format("{1} and {0}","first","second"); //change of order of parameters, also use same parameter multiple times
            Console.WriteLine(myStr);

            //Refer documentation: https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
            //String.Format for Currency where :C -> C=Curency (My computer's language according to culture)
            Console.WriteLine("CurrentCulture is {0}.", CultureInfo.CurrentCulture.Name);
            myStr = string.Format("{0:C}", 1200.25);
            Console.WriteLine(myStr);

            //String.Format for long numbers to add commas for readability
            myStr = String.Format("{0:N}",123456789);
            Console.WriteLine(myStr);

            //String.Format for percentage
            myStr = String.Format("{0:P}", 0.987); //multiplies by 100 and adds % sign 
            Console.WriteLine(myStr);

            //String.Format for phone numbers and formatting goes from right to left pound sign if extra numbers added
            myStr = String.Format("{0:(+##) ##### #####}", 919876543210); //multiplies by 100 and adds % sign 
            Console.WriteLine(myStr);

            myStr = "   Let's practice C Sharp Language      ";
            string mySubStr = myStr.Substring(5, 10); //get substring, start index, total chaacters 
            Console.WriteLine(mySubStr);

            myStr = myStr.ToUpper(); //convet to uppercase
            Console.WriteLine(myStr);

            myStr = myStr.ToLower(); //convet to lowercase
            Console.WriteLine(myStr);

            myStr = myStr.Replace(" ", "*"); //find every space i.e., " " and replace it with *
            Console.WriteLine(myStr);
            myStr = myStr.Replace("*", " ");

            mySubStr = myStr.Remove(5, 10); //remove substring from string 
            Console.WriteLine(mySubStr);

            Console.WriteLine("Length of string originally: "+myStr.Length);
            myStr = myStr.Trim(); //remove leading and trailing spaces
            Console.WriteLine("String after removing leading and trailing spaces:" + myStr +"\nLength of string: "+myStr.Length);

            //StringBuilder class used when heavy concatenation or string manipulation is required
            StringBuilder concatStr=new StringBuilder();
            int i = 1;
            while(i<=20)
            {
                concatStr.Append(i);
                concatStr.Append("---");
                i++;
            }
            Console.WriteLine(concatStr);
        }

    }
}
*/