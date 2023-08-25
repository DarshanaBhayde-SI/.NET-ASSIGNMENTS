namespace SubString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Write a program in C# Sharp to extract a substring from a given string
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter the starting index: ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the substring: ");
            int length = int.Parse(Console.ReadLine());

            if (startIndex >= 0 && startIndex < inputString.Length && length > 0 && startIndex + length <= inputString.Length)
            {
                string substring = inputString.Substring(startIndex, length);
                Console.WriteLine($"Substring: {substring}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid starting index and length.");
            }
        }
    }
}