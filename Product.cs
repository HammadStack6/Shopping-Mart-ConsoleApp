using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Mart_ConsoleApp
{
    // This is a simple shopping cart program that allows users to select products and view their cart items.
    //abstract 
    class Product // : abstract
    {
        public string[] productNames;
        public int[] productPrices;


        public List<(string name, int price)> 
             cart = new List<(string name, int price)>();


        public Product(string[] names, int[] prices)
        {
            productNames = names;
            productPrices = prices;
        }

        public string GetName(int index)
        {
            return productNames[index];
        }

        public int GetPrice(int index)
        {
            return productPrices[index];
        }

        public int Length
        {
            get { return productNames.Length; }
        }
        public void sum() { 
        int total = 0;
            
                foreach (var c in cart)
                {
                    Console.WriteLine($"{c.name}, {c.price} Rs");
                    total = total + c.price;

                }
                Console.WriteLine($"your total price is {total}");
            }
    }

}
