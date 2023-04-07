using System;
namespace task6
{
    class Overloading
    {
        public static void methodToBeOverloaded(String name)
        {
            Console.WriteLine("Name: " + name);
        }
        public static void methodToBeOverloaded(string name, int age)
        {
            Console.WriteLine("Name: " + name + "\nAge: " + age);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Overloading.methodToBeOverloaded("SANJIV");
            Overloading.methodToBeOverloaded("SANJIV", 19);
        }
    }
}
