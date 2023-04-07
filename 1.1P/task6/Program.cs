using System;
 
namespace Project
{
    class Project
    {         
        static void Main(string[] args)
        {
            int sum = 17;
            int count = 5;

            double a;
            a = (double)sum;

            int intAverage = sum/count;
            double doubleAverage = a/count;

            Console.WriteLine("Int Average result is: " + intAverage);
            Console.WriteLine("Double Average result(casting) is: " + doubleAverage);
        } 
    }
}