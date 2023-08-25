//Student Record Management

//Problem Statement:
//You are developing a student record management system for a school. Create a C# program to model student information.
//Each student should have properties like name, age, gender, and student ID.
//Additionally, implement read-write properties for course enrollment and a read-only property for the student's grade point average (GPA).

//Requirements:
//Create a Student class with private fields for name, age, gender, student ID, course enrollment, and GPA.
//Implement read - write properties for name, age, gender, and course enrolment in the Student class. The course enrolment should be a list of courses the student is currently enrolled in.
//Implement a read-only property for the student's GPA in the Student class. Assume that the GPA is calculated based on the grades of the enrolled courses.
//Create a School class that contains a list of students as an instance variable.
//Implement methods in the School class to add students, display the list of students, and calculate the overall GPA of the students in the school.
//In the Main method, allow the user to interact with the school by adding students, displaying the student list, and calculating the overall GPA of the students.
//Note: For simplicity, you can assume that the GPA is calculated using a simple average of grades (e.g., A = 4, B = 3, C = 2, D = 1, F = 0).



using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentRecordManagement
{
    internal class Program
    {

        class Student
        {

            private string name;
            private int age;
            private string gender;
            private string studentID;
            private List<string> courseEnrollment = new List<string>();
            private double gpa;


            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public string Gender
            {
                get { return gender; }
                set { gender = value; }
            }

            public string StudentID
            {
                get { return studentID; }
                set { studentID = value; }
            }

            public List<string> CourseEnrollment
            {
                get { return courseEnrollment; }
                set { courseEnrollment = value; }
            }


            public double GPA
            {
                get { return CalculateGPA(); }
            }

            private double CalculateGPA()
            {

                return 3.5;
            }
        }



        class School
        {
            private List<Student> students = new List<Student>();

            public void AddStudent(Student student)
            {
                students.Add(student);
            }

            public void DisplayStudentList()
            {
                Console.WriteLine("Student List:");
                foreach (var student in students)
                {
                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}, GPA: {student.GPA}");
                    Console.WriteLine("Courses Enrolled:");
                    foreach (var course in student.CourseEnrollment)
                    {
                        Console.WriteLine(course);
                    }
                    Console.WriteLine();
                }
            }

            public double CalculateOverallGPA()
            {
                if (students.Count == 0)
                {
                    return 0;
                }

                double totalGPA = 0;
                foreach (var student in students)
                {
                    totalGPA += student.GPA;
                }
                return totalGPA / students.Count;
            }
        }

        class Detail
        {
            static void Main(string[] args)
            {
                School school = new School();

                while (true)
                {
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. Display Student List");
                    Console.WriteLine("3. Calculate Overall GPA");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Student student = new Student();
                            Console.Write("Enter Name: ");
                            student.Name = Console.ReadLine();
                            Console.Write("Enter Age: ");
                            student.Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Gender: ");
                            student.Gender = Console.ReadLine();
                            Console.Write("Enter Student ID: ");
                            student.StudentID = Console.ReadLine();
                            Console.Write("Enter Number of Courses Enrolled: ");
                            int numCourses = int.Parse(Console.ReadLine());
                            for (int i = 0; i < numCourses; i++)
                            {
                                Console.Write($"Enter Course {i + 1} Name: ");
                                string courseName = Console.ReadLine();
                                student.CourseEnrollment.Add(courseName);
                            }
                            school.AddStudent(student);
                            Console.WriteLine("Student added successfully.\n");
                            break;

                        case 2:
                            school.DisplayStudentList();
                            break;

                        case 3:
                            double overallGPA = school.CalculateOverallGPA();
                            Console.WriteLine($"Overall GPA of the school: {overallGPA}\n");
                            break;

                        case 4:
                            Console.WriteLine("Exiting program...");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.\n");
                            break;
                    }
                }
            }
        }



    }
}
