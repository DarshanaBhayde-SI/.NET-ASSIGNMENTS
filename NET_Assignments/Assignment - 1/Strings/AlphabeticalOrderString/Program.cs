namespace AlphabeticalOrderString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Write  a program that reads a string and rewrite it in alphabetical order. For example the word STRING should be written as GINRST.
            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower();

            char[] chars = input.ToCharArray();
            Array.Sort(chars);
            string sortedString = new string(chars);

            Console.WriteLine($"The string in alphabetical order is: {sortedString}");
           
        }
    }
}