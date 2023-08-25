namespace Average_LargestArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------10 Students ---------------------------------------------------------------
            Console.WriteLine("---------Fill Marks of 10 students---------- ");
            int[] arr = new int[10];
            Console.WriteLine($"Enter {arr.Length} values: ");
            //for loop for taking 10 values
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter marks of {i + 1} student: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Calculating average
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            double average = sum / arr.Length;
            Console.WriteLine($"Average: {average}");     ///DOUBT: Not getting output in decimal

            //largest
            int largest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            Console.WriteLine($"Highest marks is: {largest}");
        }
    }
}