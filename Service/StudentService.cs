using Model;
using System;
using System.Collections.Generic;

namespace Service
{
    public sealed class StudentService
    {
        public double CalculatorBMI(Student student)
        {
            return student.Weight / Math.Pow(student.Height, 2);
        }

        public double StandardBMIPercentage(List<Student> students)
        {
            var standardStudents = new List<Student>();

            foreach (var student in students)
            {
                var bmi = this.CalculatorBMI(student);

                if (bmi >= 18.5 && bmi <= 24)
                {
                    standardStudents.Add(student);
                }
            }

            var scale = (double)standardStudents.Count / (double)students.Count;

            return scale * 100;
        }
    }
}