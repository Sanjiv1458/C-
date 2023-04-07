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
            int number = 1;
            do
            {
                sum += number;
                number++;
            }while(number <= upperbound);
            average = sum / upperbound;
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);
            Console.WriteLine("Current number: " + number+ " the sum is " + sum);
            Console.WriteLine(average);
        } 
    }
}