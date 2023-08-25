namespace StudentGradingSystemWithExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of student: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the number of grades to be entered: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Student s = new Student(name, num);
            s.EnterGrades();

            double averageGrade = s.CalculateAverage();
            Console.WriteLine($"Average Grade for {name}: {averageGrade}");
        }
    }
}