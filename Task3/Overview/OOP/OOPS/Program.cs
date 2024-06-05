using System;

// 1. Classes and Objects
class Car
{
    // Fields
    public string Model;
    public string Color;

    // Methods
    public void Start()
    {
        Console.WriteLine("Car started");
    }
}

// 2. Encapsulation
class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}

// 3. Inheritance
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

// 4. Polymorphism
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

// 5. Abstraction
abstract class AbstractShape
{
    public abstract void Draw();
}

class ConcreteCircle : AbstractShape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle (abstract)");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 1. Classes and Objects
        Car myCar = new Car();
        myCar.Model = "Toyota";
        myCar.Color = "Red";
        myCar.Start();

        // 2. Encapsulation
        BankAccount account = new BankAccount();
        account.Deposit(1000);
        Console.WriteLine("Balance: " + account.GetBalance());

        // 3. Inheritance
        Dog myDog = new Dog();
        myDog.Eat();
        myDog.Bark();

        // 4. Polymorphism
        Shape[] shapes = { new Circle(), new Square() };
        foreach (var shape in shapes)
        {
            shape.Draw();
        }

        // 5. Abstraction
        AbstractShape circle = new ConcreteCircle();
        circle.Draw();
    }
}
