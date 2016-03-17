using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Upcasting (from Cat to Animal)
            Cat cat = new Cat("Whiskers");
            cat.Color = "White";
            Animal anml = cat;
            // Color is hidden
            //Console.WriteLine(anml.Color);

            // Upcasting (from Cat to object)
            // No methods or properties from animal & cat available
            var obj = (object)cat;
            
            // Downcast back to cat (explicitly)
            Cat myCat = (Cat)anml;
            Console.WriteLine(myCat.Color);

            // Creating a list of animals using upcasting
            var animals = new List<Animal>();
            animals.Add(new Dog("Scooby"));
            animals.Add(new Bird("Tweety"));
            animals.Add(myCat);

            // Safe way to downcast - First way
            foreach (var animal in animals)
            {
                // Check if animal is a Cat object
                if (animal is Cat)
                {
                    // Downcast from Animal to Cat
                    var myAnimal = (Cat)animal;
                    Console.WriteLine(myAnimal.Color);
                }
                else
                    Console.WriteLine(animal.Name);
            }

            // Safe way to downcast - Second way
            foreach (var animal in animals)
            {
                // If animal is a Cat, it will set myAnimal to the Cat object
                // Else it will set it to null
                var myAnimal = animal as Cat;

                // Check if animal is not null, meaning it's a Cat
                if (myAnimal != null)
                {
                    Console.WriteLine(myAnimal.Color);
                }
                else
                    Console.WriteLine(animal.Name);
            }

            Console.ReadLine();

        }
    }

    interface IPet
    {
        string Owner { get; set; }
    }

    interface IFeline
    {
        void Purr();
    }

    abstract class Animal
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        private int _legs;
        public int Legs
        {
            get { return _legs; }
            protected set { _legs = value; }
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }

        public abstract void Talk();
    }

    class Dog : Animal, IPet
    {
        public Dog(string name)
        {
            Name = name;
            Legs = 4;
        }

        public string Owner { get; set; }

        public override void Talk()
        {
            Console.WriteLine("Woof woof");
        }
    }

    class Cat : Animal, IPet, IFeline
    {
        public Cat(string name)
        {
            Name = name;
            Legs = 4;
        }

        public string Owner { get; set; }

        public string Color { get; set; }

        public void Purr()
        {
            Console.WriteLine($"{Name} is purrrring");
        }

        public override void Talk()
        {
            Console.WriteLine("Meow meow!");
        }
    }

    class Bird : Animal
    {
        public Bird(string name)
        {
            Name = name;
            Legs = 2;
        }

        public override void Talk()
        {
            Console.WriteLine("Chirp chirp!");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating seeds");
            base.Eat();
        }
    }

}
