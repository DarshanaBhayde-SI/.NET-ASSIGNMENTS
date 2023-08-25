//Online Store

//Problem Statement:
//You are building an online store application. Create a C# program that models the products in the store.
//Each product should have properties like name, price, quantity in stock, and category.

//Requirements:
//Create a Product class with properties for name, price, quantity in stock, and category.
//Implement a constructor in the Product class to initialize the product's properties.
//Create a Store class that contains a list of products as an instance variable.
//Implement methods in the Store class to add products, display the list of products, and calculate the total value of products in stock.
//In the Main method, allow the user to interact with the store by adding products, displaying the product list, and calculating the total value of products in stock.

using System.IO;
using static System.Formats.Asn1.AsnWriter;

namespace OnlineStore

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Store store = new Store();

            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. Display product list");
                Console.WriteLine("3. Calculate total value of products in stock");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter quantity in stock: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter product category: ");
                        string category = Console.ReadLine();
                        Product product = new Product(name, price, quantity, category);
                        store.AddProduct(product);
                        Console.WriteLine("Product added successfully!");
                        break;

                    case "2":
                        store.DisplayProducts();
                        break;

                    case "3":
                        double totalValue = store.CalculateTotalValue();
                        Console.WriteLine($"Total value of products in stock: ${totalValue:F2}");
                        break;

                    case "4":
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}