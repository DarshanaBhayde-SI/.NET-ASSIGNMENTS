namespace ArrayCopying
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //------------------------Array copying--------------------------------------
            Console.Write("Enter size of array: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine($"Enter {num} values: \t");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr2 = new int[num];
            Console.WriteLine("Copying array 1 elements into array 2...");
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }

            Console.WriteLine();
            Console.WriteLine("Array 2 elements after copying:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}