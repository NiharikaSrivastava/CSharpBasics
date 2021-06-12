using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PriceComparisonConsoleApp
{
    class Program
    {
        public static Dictionary<string,HomepageModel> skuCache =new Dictionary<string, HomepageModel>(); //Dictionary<SkuID,HomepageModel>
        public static bool inProgress = false; //first time when app starts
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            HomepageModel homePageModel = new HomepageModel();
            homePageModel.FetchHomepageDetails();
        }
        public class HomepageModel
        {
            public string SkuId { get; set; }
            public string ProductName { get; set; }
            public int Stock { get; set; }
            public int OwnPrice { get; set; }
            public bool ExistsOnAmazon { get; set; }
            public bool ExistsOnFlipkart { get; set; }
            public Dictionary<string, int> AmazonCompetitors; //Dictionary<Competitor Name, Price>
            public Dictionary<string, int> FlipkartCompetitors;
            public HomepageModel()
            {
                SkuId = string.Empty;
                ProductName = string.Empty;
                Stock = 0;
                OwnPrice = 0;
            }
            public HomepageModel(string sID,string pName,int stock,int ownPrice)
            {
                SkuId = sID;
                ProductName = pName;
                Stock = stock;
                OwnPrice = ownPrice;
            }
            public List<string> FetchHomepageDetails()
            {
                List<string> ProductList=new List<string>(); //List of skuIDs of all products
                if(inProgress) 
                {
                    //filled ProductList returned
                    return ProductList; 
                }
                if(skuCache.Count==0)
                {
                    //fill data from database and display it to user
                    Console.WriteLine("SkuCache Empty, Preparing List in Background..");
                    //Task.Run(()=>PrepareResult()); //starts preparing result through another thread
                    PrepareResult(); //For debugging purposes
                }
                return ProductList; //return empty product list
            }
            public void PrepareResult()
            {
                inProgress = true;
                //Simulating SAPService API Call
                SAPService sp = new SAPService();
                Console.WriteLine("Fetching Data from SAP API..");
                var skuList = sp.SAPApi().Result;
                foreach (string s in skuList)
                    Console.Write(s+", ");
                AmazonService amazonService = new AmazonService();
                FlipkartService flipkartService = new FlipkartService();
                var amazonProducts = amazonService.GetHomePageDetailsFromAmazon(skuList); //execute Amazon API call and Flipkart API call in parallel
                var flipkartProducts = flipkartService.GetHomePageDetailsFromFlipkart(skuList);
                amazonProducts.Wait(-1);
                flipkartProducts.Wait(-1);
            }
        }
        class SAPService
        {
            List<string> allProductSKUs;
            public async Task<List<string>> SAPApi()
            {
                allProductSKUs = new List<string>() {"1001", "1002", "1003", "1004", "1005", //use await keyword here when data is being fetched from SAPApi
                                                     "1006", "1007", "1008", "1009", "1010",
                                                     "1011", "1012", "1013", "1014", "1015",
                                                     "1016", "1017", "1018", "1019", "1020"};
                return allProductSKUs;
            }
        }
        class AmazonService
        {
            Dictionary<string, HomepageModel> amazonProductsData = new Dictionary<string, HomepageModel>();
            public async Task<Dictionary<string, HomepageModel>> GetHomePageDetailsFromAmazon(List<string> skuList) //Task<Dictionary<string,HomepageModel>> should be the return type
            {
                HomepageModel hm1 = new HomepageModel("10001","Air Conditioner",10,30000);
                HomepageModel hm2 = new HomepageModel("10004", "Geyser", 6, 10000);
                HomepageModel hm3 = new HomepageModel("10005", "Fan", 15, 5000);
                amazonProductsData.Add(hm1.SkuId,hm1);
                amazonProductsData.Add(hm2.SkuId, hm2);
                amazonProductsData.Add(hm3.SkuId, hm3);
                return amazonProductsData;
            }
            public void GetValidAmazonProducts() //grouping of 10 and identifying products sold on amazon out of the combined product list
            {

            }
        }
        class FlipkartService
        {
            Dictionary<string, HomepageModel> flipkartProductsData = new Dictionary<string, HomepageModel>();
            public async Task<Dictionary<string, HomepageModel>> GetHomePageDetailsFromFlipkart(List<string> skuList) 
            {
                HomepageModel hm1 = new HomepageModel("10001", "Air Conditioner", 10, 30000);
                HomepageModel hm2 = new HomepageModel("10004", "Geyser", 6, 10000);
                flipkartProductsData.Add(hm1.SkuId, hm1);
                flipkartProductsData.Add(hm2.SkuId, hm2);
                return flipkartProductsData;
            }
            public void GetValidAmazonProducts() //grouping of 10 and identifying products sold on amazon out of the combined product list
            {

            }
        }

    }
}
