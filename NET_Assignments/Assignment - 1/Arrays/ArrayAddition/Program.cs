namespace ArrayAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //------------------Add array elements--------------------------------------------
            Console.Write("Enter size of array: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine($"Enter {num} values: \t");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine($"Sum of the array elements are: {sum}");
            
        }
    }
}