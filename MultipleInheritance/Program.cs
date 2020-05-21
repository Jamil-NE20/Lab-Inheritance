using System;

namespace MultipleInheritance
{


    public class Program
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            Console.WriteLine("Enter any key to Quit!");
            Console.ReadLine();
        }
    }
}
