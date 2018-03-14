using System;


class Program
{
    static void Main(string[] args)
    {
        Animal cat = new Cat("Pesho", "Whiskas");
        Animal dog = new Dog("Gosho", "Meet");

        Console.WriteLine(cat.ExplainSelf());
        Console.WriteLine(dog.ExplainSelf());
    }
}