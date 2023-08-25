using OnlineStoreInventorySystem;
using System;

//1.Inheritance  Assignment: Online Store Inventory System
//Problem Statement:
//Build an inventory system for an online store. Create a C# program to model the inventory system. Define a base class called Product with properties for product ID, name, price, and quantity in stock. Implement derived classes for different types of products, such as Electronics, Clothing, and Books. Each derived class should have additional properties specific to that type of product, such as brand for electronics, size for clothing, and author for books. Implement a method in each derived class to display the details of the product.

//Requirements:
//Create a base class Product with properties for product ID, name, price, and quantity in stock.
//Implement derived classes Electronics, Clothing, and Books, inheriting from the Product class.
//Add additional properties to the derived classes that are specific to each type of product (e.g., brand for electronics, size for clothing, author for books).
//Implement a method in each derived class to display the details of the product, including the base class properties and the additional properties specific to the derived class.
//In the Main method, create objects of each type of product and display their details.

//Example for the different class and properties
//For Electronics:
//Product ID: E001
//Name: Laptop
//Price: $800
//Quantity: 10
//Brand: Dell

//For Clothing:
//Product ID: C001
//Name: T - Shirt
//Price: $20
//Quantity: 50
//Size: Medium

//For Books:
//Product ID: B001
//Name: Harry Potter and the Sorcerer's Stone
//Price: $15
//Quantity: 20
//Author: J.K.Rowling


namespace OnlineStoreInventorySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");
           
            Product p1 = new Electronics(001, "Laptop", 40000, 20, "HP");
            p1.DisplayProductDetails();
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");

            Product p2 = new Clothing(101, "Shirts", 2000, 30, "Medium");
            p2.DisplayProductDetails();
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");

            Product p3 = new Books(1001, "Harry Potter and the Sorcerer's Stone", 1500, 25, " J.K. Rowling");
            p3.DisplayProductDetails();
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");

        }
    }
}