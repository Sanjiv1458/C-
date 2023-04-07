using System;

namespace Project
{
    class Project
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.Write("Enter a number between 1 to 9: ");
            num = Convert.ToInt16(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("ONE");
            }
            else if (num == 2)
            {
                Console.WriteLine("TWO");
            }
            else if (num == 3)
            {
                Console.WriteLine("THREE");
            }
            else if (num == 4)
            {
                Console.WriteLine("FOUR");
            }
            else if (num == 5)
            {
                Console.WriteLine("FIVE");
            }
            else if (num == 6)
            {
                Console.WriteLine("SIX");
            }
            else if (num == 7)
            {
                Console.WriteLine("SEVEN");
            }
            else if (num == 8)
            {
                Console.WriteLine("EIGHT");
            }
            else if (num == 9)
            {
                Console.WriteLine("NINE");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
