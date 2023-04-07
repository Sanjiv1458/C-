using System;

namespace Project
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Please enter the size of table: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] table = new int[n];

            int x;


            for (int i = 0; i < table.Length; i++)
            {
                Console.Write("Please enter number you want to write table: ");
                table[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < table.Length; i++)
            {
                for(int j = 1; j < 11; j++)
                {
                    x = table[i]* j;
                    Console.Write(" " + x);
                }
                Console.WriteLine(" ");
 
            }
        }
    }
}