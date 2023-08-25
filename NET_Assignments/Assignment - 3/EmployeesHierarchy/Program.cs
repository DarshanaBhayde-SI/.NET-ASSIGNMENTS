namespace EmployeesHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manager Details");
            Employee e1 = new Manager("Darshu", 112, 50000);
            e1.DisplayEmployeeDetails();

            Console.WriteLine("Developer Details");
            Employee e2 = new Developer("Yogita", 129, 40000);
            e2.DisplayEmployeeDetails();

            Console.WriteLine("SalesPerson Details");
            Employee e3 = new SalesPerson("Apurva", 133, 55000);
            e3.DisplayEmployeeDetails();


        }
    }
}