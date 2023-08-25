namespace ArrayDeletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Array before deletion: ");
            //For displaying 
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Element [{i + 1}] {arr[i]}");
            }

            Console.WriteLine("Enter position of element to delete: ");
            int pos = Convert.ToInt32(Console.ReadLine());

            //for loop for Deletion
           
                if (pos > arr.Length)
                {
                    Console.WriteLine("Deletion is not possible");
                }
                else
                {
                    for (int i = pos; i < arr.Length - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }

                    Console.WriteLine("Array after deletion: ");
                    //For displaying 
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        Console.WriteLine($"Element [{ i + 1}] {arr[i]}");
                    }
                  
            }
            
        }
    }
}



