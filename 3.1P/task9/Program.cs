using System;

namespace Project
{
    class Task9
    {
        static void Main(string[] args)
        {
            int x, y;
            int m = 0;
            Console.Write("Please enter the size of row: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the size of coloun: ");
            y = Convert.ToInt32(Console.ReadLine());

            int[,] MyArray = new int[x, y];
            int[] NewArray = new int[x * y];


            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    MyArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("{0}\t", MyArray[i, j]);

                }
                Console.Write("\n");
            }

            for (int i = 0; i < x; i++) 
            {
                for (int j = 0; j < y; j++)
                {
                    if(MyArray[i, j] % 3 == 0)
                    {
                        NewArray[m++] = MyArray[i, j];
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("{0}\t", NewArray[i]);
            }

        }
    }
}