/*
//Q7.
//Following table has information about two products to be sold to customers coming to a grocery shop:
//Product Wholesale Cost Tax Profit margin
//Wheat 5kg Bag 150 5 50
//Refined Oil 5Kg 280 10 70
//Based on content covered in our lectures of this course, design and implement an elegant solution such
//that the following Main() function outputs Total Bill = 770 when a customer purchases two wheat
//bags and one refined oil 5kg bottle. Note that cost price of the item is sum of Wholesale price, Tax and Profit margin.
//Instructions / help:
//1.Write separate functions to return cost of each type i.e. WholesaleCost(), Tax() and
//Profit() so that the item’s cost price will be WholesaleCost()+Tax() + Profit().
//2.The class Biller should not see the detail of how cost price of the item is calculated. All it does
//is to iterate over the items in the shopping cart to get their cost prices and return the total bill
//amount i.e. the sum of the cost prices of items in the shopping cart.
//3. No modification of class Buyer is allowed(other than to fill in the blank)
using System;
namespace InSem1Practice
{
    class Buyer
    {
        static void Main(string[] args)
        {
            var shoppingCart = new ShoppingItems[3]; // fill this as per your solution
            shoppingCart[0] = new Wheat5kgBag();
            shoppingCart[1] = new Wheat5kgBag();
            shoppingCart[2] = new RefinedOil5kg();
            Biller biller = new Biller();
            float totalBill = biller.CalculateTotalBill(shoppingCart);
            Console.WriteLine($"Total Bill = {totalBill}");
        }
    }
    class Biller
    {
        internal float CalculateTotalBill(ShoppingItems[] shoppingCart)
        {
            float totalBill=0;
            foreach(var shopItem in shoppingCart)
            {
                totalBill += shopItem.CalcCost();
            }
            return totalBill;
        }
    }
    internal class ShoppingItems
    {
        protected float WholesaleCost { get; set; }
        protected float Tax { get; set;  }
        protected float ProfitMargin { get; set; }
        protected float TotalCost;
        public float CalcCost()
        {
            TotalCost = WholesaleCost + Tax + ProfitMargin;
            return TotalCost;
        }
    }
    internal class Wheat5kgBag:ShoppingItems
    {
        internal Wheat5kgBag()
        {
            WholesaleCost = 150;
            Tax = 5;
            ProfitMargin=50;
        }
    }
    internal class RefinedOil5kg:ShoppingItems
    {
        internal RefinedOil5kg()
        {
            WholesaleCost=280;
            Tax=10;
            ProfitMargin=70;
        }
    }
}
*/