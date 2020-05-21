using System;

namespace HierarchicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();


            Console.WriteLine("\nEnter any key to Quit!");
            Console.ReadLine();
        }
    }
}
