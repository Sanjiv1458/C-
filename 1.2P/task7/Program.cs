using System;

namespace Project
{
    class Project
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to print the number between 1 to number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if ((i % 4 == 0) && !(i % 5 == 0))
                    Console.WriteLine(i);
            }
        }
    }
}
