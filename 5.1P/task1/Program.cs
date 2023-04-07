using System;

namespace task1
{
    class Animal
    {
        private String name;
        private String diet;
        private String location;
        private double weight;
        private int age;
        private String colour;

        public Animal(String name, String diet, String location, double weight, int age, String colour)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }

        public string AnimalName()
        {
            return this.name;
        }
        public string AnimalDiet()
        {
            return this.diet;
        }
        public string AnimalLocation()
        {
            return this.location;
        }
        public double AnimalWeight()
        {
            return this.weight;
        }
        public int AnimalAge()
        {
            return this.age;
        }
        public string AnimalColour()
        {
            return this.colour;
        }

        public void eat()
        {
            Console.Write("An animal eats");
        }

        public void sleep()
        {
            Console.WriteLine("An animal sleeps");
        }

        public void makeNoise()
        {
            Console.WriteLine("An animal makes a noises");
        }

        public void makeLionNoise()
        {
            Console.WriteLine("A lion roars");
        }

        public void makeEagleNoice()
        {
            Console.WriteLine("An eagle screeches");
        }

        public void makeWolfNoise()
        {
            Console.WriteLine("A Wolf howls");
        }

        public void eatMeat()
        {
            Console.WriteLine("Animal eats meat");
        }

        public void eatBerries()
        {
            Console.WriteLine("Animal eats berries");
        }
    }
    class ZooPark
    {
        static void Main(string[] args)
        {
            Animal williamwolf = new Animal("William the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Animal tonyTiger = new Animal("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White");
            Animal edgarEagle = new Animal("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black");

            williamwolf.sleep();
            tonyTiger.makeLionNoise();
            edgarEagle.eat();
        }
    }
}