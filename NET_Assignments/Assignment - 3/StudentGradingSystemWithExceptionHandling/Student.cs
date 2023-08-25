using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentGradingSystemWithExceptionHandling
{
    internal class Student
    {

        public string Name { get; set; }
        public double[] grades;


        public Student(string name, int num)
        {
            Name = name;
            grades = new double[num];
        }

        public void EnterGrades()
        {
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = GetValidGrade(i + 1);
            }
        }
        public double CalculateAverage()
        {
            //Calculating average of grade
            double count = 0;
            foreach (double grade in grades)
            {
                count = count + grade;
            }

            return count / grades.Length;
        }


        private double GetValidGrade(int index)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"Enter grade {index} (0-100) for  {Name}: ");
                    double grade = Convert.ToDouble( Console.ReadLine() );

                    if (grade >= 0 && grade <= 100)
                    {
                        return grade;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input! Grade must be between 0 to 100");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input! Please enter a numeric value.");
                }
            }

        }
    }
}
