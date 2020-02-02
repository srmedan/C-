using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.grades.Add(101);

            var grades = new List<double>() {12.5, 10.4, 15.6};
            grades.Add(56.1);

            var result = 0.0;
            foreach(double number in grades) 
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }





}
