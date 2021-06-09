/*
//Q3. Fill in the blanks with the line number(s) where boxing and unboxing is happening in the code below.
using System;
namespace InSem2Practice
{
    class TestBoxing //1
    { //2
        static void Main() //3
        { //4
            int i = 123; //5
            object o = i; //6
            i = 456; //7
            int j = (int)o; //8
            System.Console.WriteLine(i); //9
            System.Console.WriteLine(j); //10
        }
    }
}
//Boxing (Converting a value type to a reference type): Line 6
//Unboxing (Converting a reference type to a value type): Line 8
*/