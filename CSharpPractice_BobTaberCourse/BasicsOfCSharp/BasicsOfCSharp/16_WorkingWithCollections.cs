/*using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Initializer, without need of constructor
            Car c1 = new Car() { VIN = "C1", Make = "Maruti Suzuki", Model = "Swift Dzire" };
            Car c2 = new Car() { VIN = "C2", Make = "Honda", Model = "Amaze" };
            
            Book b1 = new Book() { Title = "The Secret", Author = "Rhonda Bryne", ISBN = "0-000-00000-0" };
            Book b2 = new Book() { Title = "Alchemist", Author = "Paulo Coelho", ISBN = "0-000-00000-0" };

            //1. ArrayLists -> dynamically sized, old style as its not strongly typed
            ArrayList arrLst = new ArrayList();
            arrLst.Add(c1);
            arrLst.Add(c2);
            arrLst.Add(b1); //lets us add an object if another type in the same collection, poses problem later during foreach
            arrLst.Remove(b1); //to ensure that only one type of objects are stored in the array list
            foreach (Car car in arrLst)
                car.displayCarDetails();

            //2. List<T> -> Generic type and can be made specific to allow only one data type by specificing it, commonly used
            List<Book> bookLst = new List<Book>();
            bookLst.Add(b1);
            bookLst.Add(b2);
            //bookLst.Add(c1); //cant add another type of object in Book specific List
            foreach (Book book in bookLst)
                book.displayBookDetails();
            List<Book> bookLst2 = new List<Book>() //Collection initializer
            {
                new Book{Title="The Story Of My Life",Author="Hellen Keller",ISBN="0-000-00000-0" },
                new Book{Title="Wings Of Fire",Author="Dr. A.P.J. Abdul Kalam",ISBN="0-000-00000-0" }
            };

            //3. Dictionary<TKey, TValue> //Key must be unique
            Dictionary<string, Car> carDict = new Dictionary<string, Car>();
            carDict.Add(c1.VIN, c1);
            carDict.Add(c2.VIN, c2);
            foreach (Car car in arrLst)
                car.displayCarDetails();
        }
        class Car
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public void displayCarDetails()
            {
                Console.WriteLine("\n***** Car Details *****");
                Console.WriteLine("VIN: " + VIN);
                Console.WriteLine("Make: " + Make);
                Console.WriteLine("Model: " + Model);
            }
        }
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public void displayBookDetails()
            {
                Console.WriteLine("\n***** Book Details *****");
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("ISBN: " + ISBN);
            }
        }
    }
}
*/