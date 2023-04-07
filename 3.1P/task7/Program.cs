using System;


namespace Project
{
    class Program
    {
        static void Main()
        {
            int[] myArray = new int[] {};
            int even = 0;
            int mult = 0;

            Console.Write("please enter the element in array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                String x = myArray[i].ToString();

                if (x.Length % 2 == 0 && myArray.Length > 10)
                {
                    even++;
                }
                else if (myArray.Length < 10)
                {
                    mult *= myArray[i];
                }
            }

            if (myArray.Length < 10)
            {
                Console.WriteLine("Number of even length elements = " + even);
            }
            else
            {
                Console.WriteLine("Multiplication = " + (myArray.Length - even));
            }
        }
    }
}