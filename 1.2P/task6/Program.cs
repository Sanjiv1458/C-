using System;
 
namespace Project
{
    class Project
    {         
        static void Main(string[] args)
        {
            int target = 5;
            Console.Write("Guess a number between 1 to 10: ");
            int guess = Convert.ToInt16(Console.ReadLine());
            do
            {
                if(guess > target)
                {
                    Console.WriteLine("your guess is higher than the target");
                    Console.Write("Please guess a number: ");
                    guess = Convert.ToInt16(Console.ReadLine());
                }
                else if(guess < target)
                {
                    Console.WriteLine("your guess is lower than the target");
                    Console.Write("Please guess a number: ");
                    guess = Convert.ToInt16(Console.ReadLine());
                }
            }while(target != guess);

            Console.Write("Enter the number(user 1): ");
            int user1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number(user 2): ");
            int user2 = Convert.ToInt32(Console.ReadLine());

            do
            {
                if(user2 > user1)
                {
                    Console.WriteLine("your guess is higher than the target");
                    Console.Write("Please guess a number: ");
                    user2 = Convert.ToInt16(Console.ReadLine());
                }
                else if(user2 < user1)
                {
                    Console.WriteLine("your guess is lower than the target");
                    Console.Write("Please guess a number: ");
                    user2 = Convert.ToInt16(Console.ReadLine());
                }
            }while(user1 != user2);
            Console.WriteLine("You have guessed the number! Well done!");
        } 
    }
}