using System;
using System.Collections.Generic;

namespace Shopping_Mart_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(
                new string[] { "Banana", "Milk", "Bread", "Eggs", "Juice" },
                new int[] { 20, 30, 40, 10, 50 }
            );

            //List<(string name, int price)> cart = new List<(string name, int price)>();

            p.cart  = new List<(string name, int price)>();
            Console.WriteLine("----------WELCOME TO THE MART----------");

            bool condition = true;
            while (condition)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {p.GetName(i)} - {p.GetPrice(i)} Rs");
                }

                Console.WriteLine("Enter the product number you want:");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input < 1 || input > 5)
                {
                    Console.WriteLine("Invalid product --- SELECT THE PRODUCT PROPERLY");
                }
                else
                {
                    Console.WriteLine($"THE PRODUCT YOU SELECTED IS {p.GetName(input - 1)} for {p.GetPrice(input - 1)} Rs");

                    p.cart.Add((p.GetName(input - 1), p.GetPrice(input - 1)));     

                    Console.WriteLine("Do you want to see your cart items? yes/no");
                    string agree1 = Console.ReadLine().ToLower();
                    if (agree1 == "yes")
                    {
                        Console.WriteLine("\n--- Your Cart Items ---");
                        p.sum();
                      
                    }
                }

                Console.WriteLine("Do you want to continue SHOPPING? type yes/no");
                string agree = Console.ReadLine().ToLower();
                if (agree == "no")
                {
                    Console.WriteLine("Thank you for visiting");
                    condition = false;
                }
            }
        }
    }
}
