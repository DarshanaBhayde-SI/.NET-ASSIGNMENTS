namespace CheckCredit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter price for purchased item: ");
            int pa = Convert.ToInt32(Console.ReadLine());

            if(pa > 10000)
            {
                Console.WriteLine("Approval denied");
            }
            else
            {
                Console.WriteLine("Successfully approved");
            }
        }
    }
}