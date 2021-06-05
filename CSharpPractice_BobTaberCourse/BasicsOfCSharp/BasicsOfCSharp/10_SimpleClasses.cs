/*using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class Prohram
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(); //myCar instance holds the address or the reference where the data of the object is stored in the memory
            myCar.make = "Chevrolet";
            myCar.model = "Aveo";
            myCar.color = "Red";
            myCar.year = 2004;
            myCar.determineMarketValue();
            myCar.displayCarDetails();
        }
        class Car
        {
            //Attributes/Properties
            public string make { get; set; } //Or type prop/propfull followe by pressing Tab twice
            public string model { get; set; }
            public string color { get; set; }
            public int year { get; set; }
            public decimal marketValue { get; set; }
            //Methods
            public decimal determineMarketValue()
            {
                if(year<2000)
                    marketValue=700000;
                else
                    marketValue = 900000;
                return marketValue;
            }
            public void displayCarDetails()
            {
                Console.WriteLine("***** Car Details *****");
                Console.WriteLine("Make: "+make);
                Console.WriteLine("Model: "+ model);
                Console.WriteLine("Color: "+ color);
                Console.WriteLine("Year: "+ year);
                Console.WriteLine("Market Value: "+ marketValue);
            }
        }
    }
}*/
