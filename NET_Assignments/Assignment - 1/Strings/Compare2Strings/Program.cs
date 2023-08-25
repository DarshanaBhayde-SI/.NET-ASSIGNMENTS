namespace Compare2Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Write a C# Sharp program to compare two substrings that only differ in case. The first comparison ignores case and the second comparison considers case
            Console.Write("Enter the first string: ");
            string firstString = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string secondString = Console.ReadLine();

            Console.Write("Enter the starting index for the first substring: ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the substrings: ");
            int length = int.Parse(Console.ReadLine());

            if (startIndex >= 0 && startIndex < firstString.Length && startIndex < secondString.Length &&
                length > 0 && startIndex + length <= firstString.Length && startIndex + length <= secondString.Length)
            {
                string firstSubstring = firstString.Substring(startIndex, length);
                string secondSubstring = secondString.Substring(startIndex, length);

                bool ignoringCaseComparison = string.Equals(firstSubstring, secondSubstring, StringComparison.OrdinalIgnoreCase);
                bool consideringCaseComparison = string.Equals(firstSubstring, secondSubstring, StringComparison.Ordinal);

                Console.WriteLine($"Ignoring case comparison: {ignoringCaseComparison}");
                Console.WriteLine($"Considering case comparison: {consideringCaseComparison}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid starting index and length.");
            }
        }
    }
}