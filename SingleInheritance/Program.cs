using System;
using System.Dynamic;

namespace SingleInheritance
{
    
        
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Console.WriteLine("\nEnter any key to Quit!");
            Console.ReadLine();

        }
        
    }
}
