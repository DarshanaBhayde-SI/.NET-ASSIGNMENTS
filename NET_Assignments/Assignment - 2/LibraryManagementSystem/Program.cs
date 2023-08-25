namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library(10);

            bool exit = false;
            while(!exit)
            {
                DisplayMenu();
                Console.WriteLine("Enter your choice (1/2/3/4/5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the author: ");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter the genre: ");
                        string genre = Console.ReadLine();
                        Console.WriteLine("Enter the quantity available: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        library.AddBook(new Book(title, author, genre, quantity));
                        Console.WriteLine("Book added successfully");
                        break;
                    case "2":
                        library.DisplayBooks();
                        break;
                    case "3":
                        Console.WriteLine("Enter the title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchByTitle(searchTitle);
                        break;
                    case "4":
                        Console.WriteLine("Enter the author to search: ");
                        string searchAuthor = Console.ReadLine();
                        library.SearchByAuthor(searchAuthor);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice. Please try again.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("---------- Library Management System -------------");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Display All Books");
            Console.WriteLine("3. Search By Title");
            Console.WriteLine("4. Search By Author");
            Console.WriteLine("5. Exit");
        }
    }
}