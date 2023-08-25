using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Product
    {
        public string Name { get; }
        public double Price { get; }
        public int QuantityInStock { get; set; }
        public string Category { get; }

        public Product(string name, double price, int quantityInStock, string category)
        {
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
            Category = category;
        }
    }

    class Store
    {
        private List<Product> products;

        public Store()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
            }
            else
            {
                Console.WriteLine("Product List:");
                foreach (var product in products)
                {
                    Console.WriteLine($"Name: {product.Name}, Price: ${product.Price:F2}, Quantity: {product.QuantityInStock}, Category: {product.Category}");
                }
            }
        }

        public double CalculateTotalValue()
        {
            double totalValue = 0;
            foreach (var product in products)
            {
                totalValue += product.Price * product.QuantityInStock;
            }
            return totalValue;
        }
    }
}