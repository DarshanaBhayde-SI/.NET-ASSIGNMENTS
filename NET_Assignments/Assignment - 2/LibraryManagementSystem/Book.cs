using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }
        public string Genre { get; set; }
        public int Quantity { get; set; }

        public Book(string title, string author, string genre, int quantity)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Quantity = quantity;
        }
    }
}
