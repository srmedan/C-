using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = new double[3] {12.5, 10.4, 15.6};
            var grades = new List<double>() {12.5, 10.4, 15.6};
            grades.Add(56.1);


            var result = 0.0;

            foreach(double number in grades) 
            {
                result += number;
            }

            Console.WriteLine(result);



        }
    }
}
