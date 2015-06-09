using System;
using System.Linq;

namespace _02.Animals
{
    class Program
    {
        static void Main()
        {
            Cat cat = new Cat("Tom", 2, "Male");
            cat.ProduceSound();

            Dog dog = new Dog("Lassie", 3, "Female");
            dog.ProduceSound();

            Frog frog = new Frog("Prince", 1, "Male");
            frog.ProduceSound();
            
            Kitten kitten = new Kitten("Bira", 1);
            kitten.ProduceSound();

            Tomcat tomcat = new Tomcat("Coolio", 4);
            tomcat.ProduceSound();

            Console.WriteLine(new string('=', 30));

            Animal[] animals = new Animal[5];
            animals[0] = cat;
            animals[1] = dog;
            animals[2] = frog;
            animals[3] = kitten;
            animals[4] = tomcat;

            double averageAge = animals.Average(x => x.Age);
            Console.WriteLine("Average age of these animals is {0:0.##} years.", averageAge);
        }
    }
}
