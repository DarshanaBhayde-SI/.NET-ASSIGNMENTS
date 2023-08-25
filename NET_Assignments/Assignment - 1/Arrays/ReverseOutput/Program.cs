namespace ReverseOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            //--------------Reverse Array-----------------
            Console.Write("Enter size of array: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine($"Enter {num} values: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Array before reversing: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Array after reversing: ");
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
           
        }
    }
}