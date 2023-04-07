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


///////////////////////////////////////////////////////////



using System;

namespace task2
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


    class Wolf : Animal
    {
        public Wolf(String name, String diet, String location, double weight, int age, String colour) : base(name, diet, location, weight, age, colour)
        {
            return;
        }
    }

    class Tiger : Animal
    {
        string species;
        private String colourStripes;
        public Tiger(String name, String diet, String location, double weight, int age, String colour, String species, String colourStripes) : base(name, diet, location, weight, age, colour)
        {
            this.colourStripes = colourStripes;
            this.species = species;
        }
    }

    class Eagle : Animal
    {
        private String species;
        private double wingSpan;
        public Eagle(String name, String diet, String location, double weight, int age, String colour, String species, double wingSpan) : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }

        public void layEgg()
        {
            Console.WriteLine("Eagle lays eggs");
        }

        public void fly()
        {
            Console.WriteLine("Eagle flies");
        }
    }

    class ZooPark
    {
        static void Main(string[] args)
        {
            Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Siberian", "White");
            Wolf williamolf = new Wolf("William the wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black", "Harpy", 98.5);

            tonyTiger.eat();
            tonyTiger.sleep();
            tonyTiger.makeNoise();

            williamolf.eat();
            williamolf.sleep();
            williamolf.makeNoise();

            edgarEagle.eat();
            edgarEagle.sleep();
            edgarEagle.makeNoise();
            edgarEagle.layEgg();
            edgarEagle.fly();
        }
    }
}

////////////////////////////////////////////////////////////////////

using System;

namespace task3
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

        public virtual void makeNoice()
        {
            Console.WriteLine("An animal makes voice");
        }
    }


    class Wolf : Animal
    {
        public Wolf(String name, String diet, String location, double weight, int age, String colour) : base(name, diet, location, weight, age, colour)
        {
            return;
        }

        public override void makeNoice()
        {
            Console.WriteLine("A Wolf howls");
        }
    }

    class Tiger : Animal
    {
        string species;
        private String colourStripes;
        public Tiger(String name, String diet, String location, double weight, int age, String colour, String species, String colourStripes) : base(name, diet, location, weight, age, colour)
        {
            this.colourStripes = colourStripes;
            this.species = species;
        }
        public override void makeNoice()
        {
            Console.WriteLine("A Tiger ROARRRRRRRRR");
        }
    }

    class Eagle : Animal
    {
        private String species;
        private double wingSpan;
        public Eagle(String name, String diet, String location, double weight, int age, String colour, String species, double wingSpan) : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }

        public void layEgg()
        {
            Console.WriteLine("Eagle lays eggs");
        }

        public void fly()
        {
            Console.WriteLine("Eagle flies");
        }
        public override void makeNoice()
        {
            Console.WriteLine("An eagle screeches");
        }
    }

    class ZooPark
    {
        static void Main(string[] args)
        {
            Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Siberian", "White");
            Wolf williamolf = new Wolf("William the wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black", "Harpy", 98.5);

            tonyTiger.eat();
            tonyTiger.sleep();
            tonyTiger.makeNoise();

            williamolf.eat();
            williamolf.sleep();
            williamolf.makeNoise();

            edgarEagle.eat();
            edgarEagle.sleep();
            edgarEagle.makeNoise();
            edgarEagle.layEgg();
            edgarEagle.fly();

            Animal baseAnimal = new Animal("Dog", "chicken", "home", 30, 3, "black");
        }
    }
}

///////////////////////////////////

using System;

namespace task4
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
        public virtual void makeNoice()
        {
            Console.WriteLine("An animal makes voice");
        }
    }


    class Wolf : Animal
    {
        public Wolf(String name, String diet, String location, double weight, int age, String colour) : base(name, diet, location, weight, age, colour)
        {
            return;
        }
        public override void makeNoice()
        {
            Console.WriteLine("A Wolf howls");
        }
    }

    class Feline : Animal
    {
        private String species;
        public Feline(String name, String diet, String location, double weight, int age, String colour, String species): base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }
        public override void makeNoice()
        {
            Console.WriteLine("A Wolf howls");
        }
    }

    class Tiger : Feline
    {
        string species;
        private String colourStripes;
        public Tiger(String name, String diet, String location, double weight, int age, String colour, String species, String colourStripes) : base(name, diet, location, weight, age, colour, species)
        {
            this.colourStripes = colourStripes;
            this.species = species;
        }
        public override void makeNoice()
        {
            Console.WriteLine("A Wolf howls");

        }
    }

    class Lion : Feline
    {
        string species;
        private String colourStripes;
        public Lion(String name, String diet, String location, double weight, int age, String colour, String species, String colourStripes) : base(name, diet, location, weight, age, colour, species)
        {
            this.colourStripes = colourStripes;
            this.species = species;
        }
        public override void makeNoice()
        {
            Console.WriteLine("A Wolf howls");
        }
    }

    class Bird : Animal
    {
        private String species;
        public Bird(String name, String diet, String location, double weight, int age, String colour, String species): base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }
        public override void makeNoice()
        {
            Console.WriteLine("A Wolf howls");
        }
    }
    class Penguin : Bird
    {
        string species;
        private String colourStripes;
        public Penguin(String name, String diet, String location, double weight, int age, String colour, String species, String colourStripes) : base(name, diet, location, weight, age, colour, species)
        {
            this.colourStripes = colourStripes;
            this.species = species;
        }
        public override void makeNoice()
        {
            Console.WriteLine("A Wolf howls");
        }
    }

    class Eagle : Bird
    {
        private String species;
        private double wingSpan;
        public Eagle(String name, String diet, String location, double weight, int age, String colour, String species, double wingSpan) : base(name, diet, location, weight, age, colour, species)
        {
            this.species = species;
        }

        public void layEgg()
        {
            Console.WriteLine("Eagle lays eggs");
        }

        public void fly()
        {
            Console.WriteLine("Eagle flies");
        }
        public override void makeNoice()
        {
            Console.WriteLine("A Wolf howls");
        }
    }

    class ZooPark
    {
        static void Main(string[] args)
        {
            Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Siberian", "White");
            Wolf williamolf = new Wolf("William the wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black", "Harpy", 98.5);

            tonyTiger.eat();
            tonyTiger.sleep();
            tonyTiger.makeNoise();

            williamolf.eat();
            williamolf.sleep();
            williamolf.makeNoise();

            edgarEagle.eat();
            edgarEagle.sleep();
            edgarEagle.makeNoise();
            edgarEagle.layEgg();
            edgarEagle.fly();
        }
    }
}

//////////////////////////////////////////


using System;
namespace task5
{
    class A
    {
        public virtual void m1()
        {
            Console.WriteLine("A's M1");
        }

        public void m2()
        {
            Console.WriteLine("A's M2");
        }

    }
    class B : A
    {
        public override void m1()
        {
            Console.WriteLine("B's MI");
        }
        public void m2()
        {
            Console.WriteLine("B's M2");
        }
    }
    class C : B
    {
        public void m1()
        {
            Console.WriteLine("C's MI");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            //PART A
            Console.WriteLine("Part A");
            a.m1();
            b.m1();
            //PART B
            Console.WriteLine();
            Console.WriteLine("Part B");
            a.m2();
            b.m2();
            c.m1();
            c.m2();
        }
    }
}

//////////////////////////////////////////

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
