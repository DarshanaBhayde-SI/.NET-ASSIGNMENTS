using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml.Linq;

namespace OnlineStoreInventorySystem
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Product(int productId, string name, int price, int quantity)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public virtual void DisplayProductDetails() //virtual is used for overriding parent and child class
        {
            Console.WriteLine($"ProductID: {ProductId}\t Name: {Name}\t Price: {Price}\t Quamtity: {Quantity}");
        }
    }

    class Electronics : Product
    {
        public Electronics(int productId, string name, int price, int quantity, string brand) : base(productId, name, price, quantity)
        {
            Console.WriteLine("Inheritating Product Class Properties into Electronics Class");
            Brand = brand;
        }

        public string Brand { get; set; }
        public override void DisplayProductDetails()  ///new: new implementation
        {
            //base.DisplayProductDetails();  //To refer to base class
            Console.WriteLine($"ProductID: {ProductId}\t Name: {Name}\t Price: {Price}\t Quamtity: {Quantity}\t Brand: {Brand}");
        }
    }

    class Clothing : Product
    {
        public Clothing(int productId, string name, int price, int quantity, string size) : base(productId, name, price, quantity)
        {
            Console.WriteLine("Inheritating Product Class Properties into Clothing Class");
            Size = size;
        }
        public string Size { get; set; }

        public override void DisplayProductDetails()
        {
            Console.WriteLine($"ProductID: {ProductId}\t Name: {Name}\t Price: {Price}\t Quamtity: {Quantity}\t Size: {Size}");
        }
    }

    class Books : Product
    {
        public Books(int productId, string name, int price, int quantity, string author) : base(productId, name, price, quantity)
        {
            Console.WriteLine("Inheritating Product Class Properties into Books Class");
            Author = author;
        }
        public string Author { get; set; }
        public override void DisplayProductDetails()
        {
            Console.WriteLine($"ProductID: {ProductId}\t Name: {Name}\t Price: {Price}\t Quamtity: {Quantity}\t Author: {Author}");
        }
    }
}
