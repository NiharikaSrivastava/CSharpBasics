/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BasicsOfCSharp //LINQ -> Language Integrated Query
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carLst= new List<Car>()
            {
                new Car{ VIN = "A1", Make = "BMW", Model = "550i", StickerPrice=55000, Year = 2000 },
                new Car() { VIN = "A2", Make = "Ford", Model = "Fiesta", StickerPrice=35000, Year = 1990 },
                new Car{ VIN = "A3", Make = "Toyota", Model = "Etios", StickerPrice=75000, Year = 2003 },
                new Car{ VIN = "A4", Make = "BMW", Model = "55i", StickerPrice=25000, Year = 2009 },
                new Car{ VIN = "A5", Make = "BMW", Model = "745li", StickerPrice=57000, Year=1998 }
            };
            //LINQ Query Syntax (Similar to SQL)
            var bmws=from car in carLst  //var in C# is similar to auto in C++
                     where car.Make == "BMW" && car.Year>=2000
                     select car;
            Console.WriteLine("\nOnly BMW Cars which were made in and after 2000 (SQL)");
            foreach (var car in bmws)
                car.displayCarDetails();
            //LINQ Method Syntax
            var bmwsM = carLst.Where(p => p.Make=="BMW" && p.Year>=2000);
            Console.WriteLine("\nOnly BMW Cars which were made in and after 2000 (Method)");
            foreach (var car in bmwsM)
                car.displayCarDetails();

            Console.WriteLine("\nDisplay Car Details in descending order according to Make (SQL)");
            var orderedCars = from car in carLst
                              orderby car.Make descending
                              select car;
            //var orderedCarsM = carLst.OrderByDescending(p=>p.Make);
            foreach (var car in orderedCars)
                car.displayCarDetails();

            Console.WriteLine("\nDetails of First BMW in List and Latest(Method)");
            var firstBMW = carLst.OrderByDescending(p => p.Year).First(p=>p.Make=="BMW");
            firstBMW.displayCarDetails();

            Console.WriteLine("\nIs it true that all our cars were manufactured after 2000?");
            Console.WriteLine(carLst.TrueForAll(p=>p.Year>2000));

            Console.WriteLine("\nShort ForEach");
            carLst.ForEach(p => p.StickerPrice -= 1000);
            carLst.ForEach(p=>Console.WriteLine("VIN: {0}, Sticker Price:{1:C}",p.VIN,p.StickerPrice));

            Console.WriteLine("\nDoes a Car exist with model as Fiesta");
            Console.WriteLine(carLst.Exists(p=>p.Model=="Fiesta"));

            Console.WriteLine("\nTotal Value of All Cars");
            Console.WriteLine("{0:N}",carLst.Sum(p => p.StickerPrice));
            Console.WriteLine("\nType of bmws variable: " + bmws.GetType());

            Console.WriteLine("\nCreate New Anonymous Type at Runtime and store them in Anonymous type collection: " + bmws.GetType());
            var newBmws = from car in carLst  
                       where car.Make == "BMW" && car.Year >= 2000
                       select new { car.VIN, car.Year}; //now this object contains only these two parameters
            Console.WriteLine("Type: "+newBmws.GetType());

        }
        class Car
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public decimal StickerPrice { get; set; }
            public int Year { get; set; }
            public void displayCarDetails()
            {
                Console.WriteLine("\n***** Car Details *****");
                Console.WriteLine("VIN: " + VIN);
                Console.WriteLine("Make: " + Make);
                Console.WriteLine("Model: " + Model);
                Console.WriteLine("StickerPrice: " + StickerPrice);
                Console.WriteLine("Year: " + Year);
            }
        }
    }
}
*/