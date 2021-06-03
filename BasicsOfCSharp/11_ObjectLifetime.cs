/*using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.noOfCars = 0;
            Car myCar = new Car("Chevrolet", "Aveo", "Red", 2004, 900000);
            Car otherCar;
            Car latestCar = new Car("Maruti Suzuki","Swift Desire","Silver",1990,500000);
            myCar.displayCarDetails();
            otherCar = myCar; //copying reference of object
            otherCar.displayCarDetails();
            latestCar.displayCarDetails();
            Car.TotalCars();
            otherCar = null; //reference count reduced by one
            myCar = null; //reference count set to 0, .Net Framework will not garbage collect the object (deterministic approach)
        }//out of scope, .Net Framework performs garbage collection for all identifiers in this scope automatically (indeterministic approach)
        class Car
        {
            public string make { get; set; }
            public string model { get; set; }
            public string color { get; set; }
            public int year { get; set; }
            public decimal marketValue { get; set; }
            public static int noOfCars { get; set; }

            public Car() //default Constructor
            {
                make = "";
                model = "";
                color = "";
                year = 0;
                marketValue = 0;
                noOfCars++;
            }
            public Car(string mk, string mdl, string clr, int yr, decimal markVal) //overloaded Constructor
            {
                make = mk;
                model = mdl;
                color = clr;
                year = yr;
                marketValue = markVal;
                noOfCars++;
            }
            public static void TotalCars() //static method can only access static members and not instance members
            {
                Console.WriteLine("Total No. of Cars we have= "+noOfCars);
            }
            public void displayCarDetails()
            {
                Console.WriteLine("\n***** Car Details *****");
                Console.WriteLine("Make: " + make);
                Console.WriteLine("Model: " + model);
                Console.WriteLine("Color: " + color);
                Console.WriteLine("Year: " + year);
                Console.WriteLine("Market Value: " + marketValue);
            }
        }
    }
}
*/