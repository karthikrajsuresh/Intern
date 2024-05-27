using System;

class Program
{
    static void Main(string[] args)
    {
        Problem24_Encapsulation();
    }
    static void Problem24_Encapsulation()
    {
        Person person = new Person();
        person.Name = "nick";
        person.Age = 26;
        person.DisplayPersonDetails();
    }
}
public class Person
{
    private string name = string.Empty;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                throw new ArgumentException("Age cannot be negative");
            }
        }
    }

    public void DisplayPersonDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
