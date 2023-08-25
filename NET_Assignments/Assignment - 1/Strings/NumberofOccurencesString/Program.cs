namespace NumberofOccurencesString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a program that counts the number of occurrences of a particular character in a line of text.
            Console.WriteLine("Enter the String");
            string str = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the character to need count");
            char ch = Convert.ToChar(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (ch == str[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}