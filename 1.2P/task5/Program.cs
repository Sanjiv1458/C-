using System;
 
namespace Project
{
    class Project
    {         
        static void Main(string[] args)
        { 
            int sum;
            int j;

            for(j = -5, sum = 0; sum<=350; j+= 5, sum+=j)
            {
                Console.WriteLine(sum);
                Console.WriteLine(j);
            }
            
            int x;
            for(x = 0; x<500; x+=5)
            {
                Console.WriteLine( x );
            }
        } 
    }
}