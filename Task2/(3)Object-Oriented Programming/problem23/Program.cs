using System;
class Program
{
    static void Main(string[] args)
    {
        Problem23_PolymorphismWithSpeakMethod();
    }
    static void Problem23_PolymorphismWithSpeakMethod()
    {
        Animal animal = new Animal();
        animal.Speak();
        Dog dog = new Dog();
        dog.Speak();
        Animal someAnimal = new Dog();
        someAnimal.Speak();
    }
}
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}