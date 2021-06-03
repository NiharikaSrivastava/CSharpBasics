/*using System;
using System.Collections.Generic;
using System.Text;
using MyCodeLibrary; //To use own library: Solution Explorer-> Dependencies -> Add Project Reference -> Browse -> Path (uptil bin->Release) -> Select .dll library
                     //Gets added in Assemblies section, also .dll library gets added in bin->Debug folder of current project
namespace BasicsOfCSharp   
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string result = myScrape.ScrapeWebPage("https://www.youtube.com/", @"C:\Users\zoomp\Desktop\Niharika DAIICT study material\Summer Internship\C# Learning Youtube\BasicsOfCSharp\webScrape2.txt");
            Console.WriteLine("Web Scraping 'https://www.youtube.com/'\n\n" + result);
            //result = myScrape.ScrapeWebPage("https://www.youtube.com/"); //another method of my library can be accessed
        }
    }
}
*/