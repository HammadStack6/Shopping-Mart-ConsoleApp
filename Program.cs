using System;

namespace Shopping_Mart_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
    

            string[] Products = { "Banana", "Milk", "Bread", "Eggs", "Juice" }; // 5 products
            int[] Prices = { 20, 30, 40, 10, 50 }; // Prices for each product
            List<(string name, int price)> cart = new List<(string name, int price)>(); //this

            Console.WriteLine("----------WELCOME TO THE MART----------");

            bool condition = true;
            while (condition) { 
            
            for (int i = 0; i < Products.Length; i++)
                {
                    Console.WriteLine($"{i+1}. {Products[i]} - {Prices[i]}");

                }

                Console.WriteLine("enter the product number you want ");
                
                int input = Convert.ToInt32(Console.ReadLine());
                if (input <1 || input > 5)
                {
                    Console.WriteLine("in valid product--- SELECT THE PRODUCT PROPERLY");
                 
                }
                Console.WriteLine($"THE PRODUCT YOU SELECTED IS {Products[input-1]}  for {Prices[input-1]} Rs");
                Console.WriteLine("do you want to see your cart items  yes/no ");
                String agree1 = Console.ReadLine().ToLower();
                if (agree1 == "no")
                {
                    condition = true;
                }
                cart.Add((Products[input - 1], Prices[input - 1])); //this need to understand

                if (agree1 == "yes")
                {
                    Console.WriteLine("\n--- Your Cart Items ---"); //this
                    foreach (var c in cart)
                    {
                        Console.WriteLine($"{c.name} , {c.price} Rs");
                    }
                }//this





                Console.WriteLine("Do you want to continue SHOPPING type yes/no");
                String agree = Console.ReadLine().ToLower();
                if (agree =="no")
                {
                    Console.WriteLine("Thank you for visiting");
                    condition = false;
                }
            
            
            
            
            
            }



        }
    }
}
