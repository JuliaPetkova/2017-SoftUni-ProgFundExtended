using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Animals
{

    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Parameter { get; set; }
        public Dog(string name, int age, int parameter)
        {
            Name = name;
            Age = age;
            Parameter = parameter;
        }
        public void Sound()
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
        public void Sound()
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
        public void Sound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }

    }

    class Animals
    {
        static void Main()
        {
            List<Dog> dogs = new List<Dog>();
            List<Cat> cats = new List<Cat>();
            List<Snake> snakes = new List<Snake>();

            var input = Console.ReadLine();

            while (input != "I’m your Huckleberry")
            {
                var param = input.Split().ToArray();

                if (param.Length > 2)
                {
                    var type = param[0];
                    string name = param[1];
                    int age = int.Parse(param[2]);
                    int parameter = int.Parse(param[3]);

                    switch (type)
                    {
                        case "Dog":
                            dogs.Add(new Dog(name, age, parameter));
                            break;

                        case "Cat":
                            cats.Add(new Cat(name, age, parameter));
                            break;

                        case "Snake":
                            snakes.Add(new Snake(name, age, parameter));
                            break;
                        default:
                            break;
                    }
  
                }
                else
                {                    
                    string name = param[1];

                    foreach (var dog in dogs)
                    {
                        if (dog.Name == name)
                        {
                            dog.Sound();
                        }
                    }
                    foreach (var cat in cats)
                    {
                        if (cat.Name == name)
                        {
                            cat.Sound();
                        }
                    }
                    foreach (var snake in snakes)
                    {
                        if (snake.Name == name)
                        {
                            snake.Sound();
                        }
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.Parameter}");
            }

            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.Parameter}");
            }

            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.Parameter}");
            }

        }
    }
}