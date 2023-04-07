using System;

namespace Project
{
    class Task8
    {
        static void Main(string[] args)
        {
            double[] FuncTwo = new double[] { 1, 11.2, 23.56, 86.6, 54.34 };
            double avg = 0;
            for(int i = 0; i < FuncTwo.Length; i++)
            {
                avg += FuncTwo[i]/FuncTwo.Length;
                FuncTwo[i] = FuncTwo[i] - avg;
            }
            Console.WriteLine("Average value of array: " + avg);
            Console.WriteLine("===: New Array :===");
            for (int i = 0; i < FuncTwo.Length; i++)
            {
                Console.WriteLine(FuncTwo[i]);
            }
        }
    }
}