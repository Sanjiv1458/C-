///////////////:::::::::::::::|  TASK - 1  |:::::::::::::::\\\\\\\\\\\\\\\\\\

using System;

namespace project
{
    class Task1
    {
        static void Main(string[] args)
        {
            double[] myArray = new double[10];
            myArray[0] = 1;
            myArray[1] = 1.1;
            myArray[2] = 1.2;
            myArray[3] = 1.3;
            myArray[4] = 1.4;
            myArray[5] = 1.5;
            myArray[6] = 1.6;
            myArray[7] = 1.7;
            myArray[8] = 1.8;
            myArray[9] = 1.9;
            
            //printing array's elements

            Console.WriteLine("The elemnt at index0 int the array is: " + myArray[0]);
            Console.WriteLine("The elemnt at index1 int the array is: " + myArray[1]);
            Console.WriteLine("The elemnt at index2 int the array is: " + myArray[2]);
            Console.WriteLine("The elemnt at index3 int the array is: " + myArray[3]);
            Console.WriteLine("The elemnt at index4 int the array is: " + myArray[4]);
            Console.WriteLine("The elemnt at index5 int the array is: " + myArray[5]);
            Console.WriteLine("The elemnt at index6 int the array is: " + myArray[6]);
            Console.WriteLine("The elemnt at index7 int the array is: " + myArray[7]);
            Console.WriteLine("The elemnt at index8 int the array is: " + myArray[8]);
            Console.WriteLine("The elemnt at index9 int the array is: " + myArray[9]);
        }
    }
}

///////////////:::::::::::::::|  TASK - 2  |:::::::::::::::\\\\\\\\\\\\\\\\\\

using System;

namespace project
{
    class Task2
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            myArray[0] = 0;
            myArray[1] = 1;
            myArray[2] = 2;
            myArray[3] = 3;
            myArray[4] = 4;
            myArray[5] = 5;
            myArray[6] = 6;
            myArray[7] = 7;
            myArray[8] = 8;
            myArray[9] = 9;
            
            //printing array's elements

            for(int i =0; i<10; i++)
            {
                Console.WriteLine("The element at position " + " in the arrary is " + myArray[1]);
            }
        }
    }
}

///////////////:::::::::::::::|  TASK - 3  |:::::::::::::::\\\\\\\\\\\\\\\\\\

using System;

namespace project
{
    class Task3
    {
        static void Main(string[] args)
        {
            int[] studentArray = {87, 68, 94, 100, 83, 78, 85, 91, 76, 87};
            
            int total = 0;
            //printing array's elements

            for(int i =0; i<studentArray.Length; i++)
            {
                total += studentArray[i];
            }

            Console.WriteLine("The total marks for the student is: " + total);
            Console.WriteLine("This consist of " + studentArray.Length + " marks");
            Console.WriteLine("Therefore the average marks is " + (total/studentArray.Length));
        }
    }
}

///////////////:::::::::::::::|  TASK - 4  |:::::::::::::::\\\\\\\\\\\\\\\\\\

using System;

namespace project
{
    class Task4
    {
        static void Main(string[] args)
        {
            string[] studentNames = new string[6];
            studentNames[0] = "my";
            studentNames[1] = "name";
            studentNames[2] = "is";
            studentNames[3] = "sanjiv";
            studentNames[4] = "kumar";
            studentNames[5] = "singh";
            
            //printing array's elements

            for(int i =0; i<studentNames.Length; i++)
            {
                Console.Write(studentNames[i]+ " ");
            }
        }
    }
}

///////////////:::::::::::::::|  TASK - 5  |:::::::::::::::\\\\\\\\\\\\\\\\\\

using System;


namespace project
{
    class Task5
    {
        static void Main(string[] args)
        {
            double [] myArray = new double[10];
            double CurrentLargest = 0, CurrentSmallest = 0;
            int CurrentSize = 0;

            for(CurrentSize =0;  CurrentSize< 10; CurrentSize++)
            {
                Console.Write("please Enter " + CurrentSize + "(index) number: ");
                myArray[CurrentSize] = Convert.ToDouble(Console.ReadLine());
            }

            for(CurrentSize =0;  CurrentSize< 10; CurrentSize++)
            {
                CurrentLargest = myArray[0];
                if(CurrentLargest < myArray[CurrentSize])
                {
                    CurrentLargest = myArray[CurrentSize];
                }
            }

            for(CurrentSize =0;  CurrentSize< 10; CurrentSize++)
            {
                CurrentSmallest = myArray[0];
                if(CurrentSmallest > myArray[CurrentSize])
                {
                    CurrentSmallest = myArray[CurrentSize];
                }
            }

            Console.WriteLine("====: array :====");

            for(CurrentSize =0;  CurrentSize< 10; CurrentSize++)
            {
                Console.WriteLine("Index(" +CurrentSize +")  " +myArray[CurrentSize]);
            }
            Console.WriteLine("largest number in array is "+ CurrentLargest);
            Console.WriteLine("smallest number in array is "+CurrentSmallest);
        }
    }
}

///////////////:::::::::::::::|  TASK - 6  |:::::::::::::::\\\\\\\\\\\\\\\\\\

using System;

namespace project
{
    class Task6
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 } };

            //printing array's elements

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            List<String> myStudentList = new List<string>();
            Random randomValue = new Random();
            int randomNumber = randomValue.Next(1, 12);

            Console.WriteLine("you need to add "+ randomNumber + " students to your class list");
            for(int i =0; i < randomNumber; i++)
            {
                Console.Write("please enter the name of Student " + (i + 1) + ": ");
                myStudentList.Add(Console.ReadLine());
                Console.WriteLine();
            }

            for(int i = 0; i < randomNumber; i++) 
            {
                Console.WriteLine(myStudentList[i] + "\n ");
            }
        }
    }
}

///////////////:::::::::::::::|  TASK - 7  |:::::::::::::::\\\\\\\\\\\\\\\\\\

using System;


namespace Project
{
    class task7
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

///////////////:::::::::::::::|  TASK - 8  |:::::::::::::::\\\\\\\\\\\\\\\\\\

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

///////////////:::::::::::::::|  TASK - 9  |:::::::::::::::\\\\\\\\\\\\\\\\\\

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

///////////////:::::::::::::::|  TASK - 10  |:::::::::::::::\\\\\\\\\\\\\\\\\\

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


//////////////////////:::::::::::::::::THANKS:::::::::::::::\\\\\\\\\\\\\\\\\\\\\\\