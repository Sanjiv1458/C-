using System;
namespace task2
{
    class Bird
    {
        public string Name { get; set; }
        public Bird()
        {
        }
        public virtual void fly()
        {
            Console.WriteLine("flap, flap, flap");
        }
        public override string ToString()
        {
            return "A Bird called name" + Name;
        }

    }
    
    class Penguin : Bird
    {
        public override void fly()
        {
            Console.WriteLine("Penguins cannot fly");
        }
        public override string ToString()
        {
            return "A penguin named" + base.Name;
        }

    }

    class Duck : Bird
    {
        public double size { get; set; }
        public String kind { get; set; }
        public override string ToString()
        {
            return "A duck named" + base.Name + " is a " + size + " inch " + kind;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird();
            Bird bird2 = new Bird();
            bird1.Name = " Feathers";
            bird2.Name = " Polly";
            Console.WriteLine(bird1.ToString());
            bird1.fly();
            Console.WriteLine(bird2.ToString());
            bird2.fly();
            Console.ReadLine();

            Penguin penguin1 = new Penguin();
            Penguin penguin2
            = new Penguin();
            penguin1.Name = " Happy Feet";
            penguin2.Name = " Gloria";

            Console.WriteLine(penguin1.ToString());
            penguin1.fly();
            Console.WriteLine(penguin2.ToString());
            penguin2.fly();

            Duck duck1 = new Duck();
            Duck duck2 = new Duck();
            duck1.Name = " Daffy";
            duck1.size = 15;
            duck1.kind = " Mallard";

            duck2.Name = " Donald";
            duck2.size = 20;
            duck2.kind = " Decoy";

            Console.WriteLine(duck1.ToString());
            Console.WriteLine(duck2.ToString());

            List<Bird> birds = new List<Bird>();
            birds.Add(bird1);
            birds.Add(bird2);
            birds.Add(penguin1);
            birds.Add(penguin2);
            birds.Add(duck1);
            birds.Add(duck2);
            birds.Add(new Bird{Name = " Birdy"});
            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }

            Duck duck3 = new Duck();
            Duck duck4 = new Duck();
            duck3.Name = "trump";
            duck3.size = 10;
            duck3.kind = "deshi";

            duck4.Name = "biden";
            duck4.size = 20;
            duck4.kind = "bideshi";

            List <Duck> ducksToAdd = new List<Duck>();
            {
                ducksToAdd.Add(duck3);
                ducksToAdd.Add(duck4);
            };

            IEnumerable<Bird>upcastDucks = ducksToAdd;
            birds.Add(new Bird(){Name = " Father"});
            birds.AddRange(upcastDucks);

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }
        }
    }
}