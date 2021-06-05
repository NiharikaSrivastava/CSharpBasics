/*using System; //namespaces help in recognizing the fullname of the class, Classes refernced who are present inside this namespace only
using System.Net;
using System.IO;
namespace BasicsOfCSharp 
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient myClient = new WebClient();
            string reply = myClient.DownloadString("https://www.google.com/"); //Web Scraping and storing downloaded html data in reply string
            Console.WriteLine("Web Scraping 'https://www.google.com/'\n\n" + reply);
            File.WriteAllText(@"C:\Users\zoomp\Desktop\Niharika DAIICT study material\Summer Internship\C# Learning Youtube\BasicsOfCSharp\webScrape.txt",reply); //Writing to file
        }
    }
}*/