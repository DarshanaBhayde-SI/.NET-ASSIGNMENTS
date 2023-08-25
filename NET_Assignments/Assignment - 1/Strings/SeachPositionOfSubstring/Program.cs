namespace SeachPositionOfSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Write a program in C# Sharp to search the position of a substring within a string
            Console.Write("Enter a string: ");
            string mainString = Console.ReadLine();

            Console.Write("Enter the substring to search for: ");
            string subString = Console.ReadLine();

            int position = mainString.IndexOf(subString);

            if (position != -1)
            {
                Console.WriteLine($"Substring found at position: {position}");
            }
            else
            {
                Console.WriteLine("Substring not found in the given string.");
            }
        }
    }
}