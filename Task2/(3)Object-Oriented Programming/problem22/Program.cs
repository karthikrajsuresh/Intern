using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal is making a sound.");
    }
}
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {        Animal animal = new Animal();
        Console.WriteLine("Animal methods:");
        animal.MakeSound();
        animal.Eat();
        Console.WriteLine();
        Dog dog = new Dog();
        Console.WriteLine("Dog methods:");
        dog.MakeSound();
        dog.Eat();
    }
}
