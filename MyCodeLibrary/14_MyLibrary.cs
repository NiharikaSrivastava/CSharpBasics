using System;
using System.Net;
/*using System.IO;

namespace MyCodeLibrary //Build Release Version as well
{
    public class Scrape //My own Class for Web Scraping
    {
        public string ScrapeWebPage(string url)
        {
            return GetWebpage(url);
        }
        public string ScrapeWebPage(string url,string path)
        {
            string reply = GetWebpage(url);
            File.WriteAllText(path, reply); //Writing to file
            return reply;
        }
        public string GetWebpage(string url) //moving common code to separate method, DRY principle
        {
            WebClient myClient = new WebClient();
            return myClient.DownloadString(url); //Web Scraping 
        }
    }
}*/