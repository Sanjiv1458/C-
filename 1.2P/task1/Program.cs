using System;
 
namespace Project
{
    class Project
    {         
        static void Main(string[] args)
        { 
            int sum = 0;
            double average;
            int upperbound = 100;

            for(int number = 1; number <= upperbound; number++)
            {
                sum += number;
            }
            average = sum / upperbound;
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);
        } 
    }
}