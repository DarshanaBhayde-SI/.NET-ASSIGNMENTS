using System;
using System.Collections.Generic;

namespace OnlineShoppingCart
{
    internal class Program
    {
        class Item
        {
            public string Name { get; }
            public decimal Price { get; }
            public int Quantity { get; }

            public Item(string name, decimal price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }

        class ShoppingCart
        {
            private List<Item> items = new List<Item>();

            public void AddItem(Item item)
            {
                items.Add(item);
            }

            public void DisplayCartContents()
            {
                Console.WriteLine("Cart Contents:");
                foreach (var item in items)
                {
                    Console.WriteLine($"Item: {item.Name}, Price: ${item.Price}, Quantity: {item.Quantity}");
                }
                Console.WriteLine();
            }

            public decimal TotalCost
            {
                get
                {
                    decimal total = 0;
                    foreach (var item in items)
                    {
                        total += item.Price * item.Quantity;
                    }
                    return total;
                }
            }
        }

        class Detail
        {
            static void Main(string[] args)
            {
                ShoppingCart cart = new ShoppingCart();

                while (true)
                {
                    Console.WriteLine("1. Add Item to Cart");
                    Console.WriteLine("2. Display Cart Contents");
                    Console.WriteLine("3. Calculate Total Cost");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Item Name: ");
                            string itemName = Console.ReadLine();
                            Console.Write("Enter Item Price: ");
                            decimal itemPrice = decimal.Parse(Console.ReadLine());
                            Console.Write("Enter Item Quantity: ");
                            int itemQuantity = int.Parse(Console.ReadLine());
                            Item item = new Item(itemName, itemPrice, itemQuantity);
                            cart.AddItem(item);
                            Console.WriteLine("Item added to cart.\n");
                            break;


                        case 2:
                            cart.DisplayCartContents();
                            break;

                        case 3:
                            decimal totalCost = cart.TotalCost;
                            Console.WriteLine($"Total Cost of the Cart: ${totalCost}\n");
                            break;

                        case 4:
                            Console.WriteLine("Exiting program...");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.\n");
                            break;
                    }
                }
            }
        }

    }
}
