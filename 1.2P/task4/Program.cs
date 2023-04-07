using System;
 
namespace Project
{
    class Project
    {       
        static void Main(string[] args)
        { 
            int c = 0, product = 0;
            while (c <= 5)
            {
                product = product * 5;
                c = c + 1;
                Console.WriteLine("product: " + product);
                Console.WriteLine("c " + c);
            }
            int a = 1, b = 1, sum = 0;
            while (a == b)
            {
                sum = sum + a;
                b = b + 2; 
                Console.WriteLine("sum: " + sum);
                Console.WriteLine("b " + b);
            }
            int x = 1;
            int total = 0;
            while (x <= 10)
            {
                total = total + x;
                x = x + 1; 
                Console.WriteLine("total: "+ total);
                Console.WriteLine("x: "+ x);
            }
            int y = 0;
            while (y < 10) 
            {   
                y = y + 1; 
                Console.WriteLine("y: " + y);
            }
            int z = 1;
            while (z > 0) 
            {
                z = z - 1;
                Console.WriteLine("z: " +z);
            }
            for(int count = 1; count < 100; count++) 
            {
                Console.WriteLine(count);
            }
            for(int i =1; i>10; i++) 
            {
                if (i>2) 
                {
                    Console.WriteLine (i);
                }
            }
        } 
    }
}