using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {

        private Book[] books;
        private int bookCount;
        
        public Library(int capacity)
        {
            books = new Book[capacity];
            bookCount = 0;
        }

        public void AddBook(Book book)
        {
            if(bookCount < books.Length)
            {
                books[bookCount] = book;
                bookCount++;
            }
            else
            {
                Console.WriteLine("Library is full. Cannot add more books");
            }
        }

        public void DisplayBooks()
        {
            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine("Book List:");
                var book = books[i];
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Quantity Available: {book.Quantity}");
            }
        }

        public void SearchByTitle(string title)
        {
            Console.WriteLine($"-------- Books with Title: {title} --------");
            Console.WriteLine("Title \t Author \t Genre \t Quantity Available");

            for (int i = 0; i < bookCount; i++)
            {
                var book = books[i];
                if (book.Title.ToLower().Contains(title.ToLower()))
                {
                    Console.WriteLine($"{book.Title}\t {book.Author}\t {book.Genre}\t {book.Quantity}");
                }
            }
        }

        public void SearchByAuthor(string author)
        {
            Console.WriteLine($"-------- Books with Author: {author} --------");
            Console.WriteLine("Title \t Author \t Genre \t Qunatity Available");

            for (int i = 0; i < bookCount; i++)
            {
                var book = books[i];
                if (book.Author.ToLower().Contains(author.ToLower()))
                {
                    Console.WriteLine($"{book.Title}\t {book.Author}\t {book.Genre}\t {book.Quantity}");
                }
            }
        }
    }
}
