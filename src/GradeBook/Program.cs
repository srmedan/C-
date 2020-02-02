using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = new double[3];
            numbers[0] = 4;
            numbers[1] = 9;
            numbers[2] = 12;

            double result = numbers[0] + numbers[1] + numbers[2];
                        
            Console.WriteLine(result);



        }
    }
}
