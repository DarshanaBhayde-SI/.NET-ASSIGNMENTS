namespace ShapesHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*****************  CIRCLE  ***************** ");

            Console.WriteLine("Enter radius of Circle: ");
            double rc = Convert.ToDouble(Console.ReadLine());
            double pi = 3.14;
            Circle c = new Circle(rc, pi);

            c.DisplayShapeDetails();

            Console.WriteLine("\n*****************  RECTANGLE  ***************** ");

            Console.WriteLine("Enter length of Rectangle: ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth of Rectangle: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Rectangle r = new Rectangle(l, b);
            
            r.DisplayShapeDetails();

            Console.WriteLine("\n*****************  TRIANGLE  ***************** ");

            Console.WriteLine("Enter base(side1) of Triangle: ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height(side2) of Triangle: ");
            double s2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side3 of Triangle: ");
            double s3 = Convert.ToDouble(Console.ReadLine());
            Triangle t = new Triangle(s1, s2, s3);

            t.DisplayShapeDetails();
        }
    }
}