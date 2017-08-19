using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Animals
{ 

    class Animals
    {
        static void Main()
        {
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            string input = Console.ReadLine();

            while (input != "I'm your Huckleberry")
            {
                string[] tokens = input.Split(' ');

                string type = tokens[0];

                if (type == "talk")
                {
                    string name = tokens[1];

                    if (dogs.ContainsKey(name))
                    {
                        dogs[name].ProduceSound();
                    }
                    else if (cats.ContainsKey(name))
                    {
                        cats[name].ProduceSound();
                    }
                    else
                    {
                        snakes[name].ProduceSound();
                    }
                }
                else
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    int parameter = int.Parse(tokens[3]);

                    if (type == "Dog")
                    {
                        dogs.Add(name, new Dog(name, age, parameter));
                    }
                    else if (type == "Cat")
                    {
                        cats.Add(name, new Cat(name, age, parameter));
                    }
                    else
                    {
                        snakes.Add(name, new Snake(name, age, parameter));
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in dogs)
            {
                Dog dog = item.Value;
                Console.WriteLine("Dog: {0}, Age: {1}, Number Of Legs: {2}",
                    dog.Name, dog.Age, dog.Parameter);
            }

            foreach (var item in cats)
            {
                Cat cat = item.Value;
                Console.WriteLine("Cat: {0}, Age: {1}, IQ: {2}",
                    cat.Name, cat.Age, cat.Parameter);
            }

            foreach (var item in snakes)
            {
                Snake snake = item.Value;
                Console.WriteLine("Snake: {0}, Age: {1}, Cruelty: {2}",
                    snake.Name, snake.Age, snake.Parameter);
            }
        }
    }

    class Dog
    {
        public int Age { get; set; }
        public int Parameter { get; set; }
        public string Name { get; set; }

        public Dog(string name, int age, int parameter)
        {
            Name = name;
            Age = age;
            Parameter = parameter;
        }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Parameter { get; set; }

        public Cat(string name, int age, int parameter)
        {
            Name = name;
            Age = age;
            Parameter = parameter;
        }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Parameter { get; set; }

        public Snake(string name, int age, int parameter)
        {
            Name = name;
            Age = age;
            Parameter = parameter;
        }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }
}