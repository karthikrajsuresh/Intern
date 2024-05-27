using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running LINQ examples:");
        Problems.UseLINQToFilter();
        Problems.UseLINQToSort();
        Problems.UseLINQToSelect();
        Problems.UseLINQToGroup();
        Problems.UseLINQToJoin();
        Problems.UseLINQToAggregate();
        Problems.UseLINQToFindElement();
        Problems.UseLINQWithAnonymousTypes();
        Problems.UseLINQWithCollections();
        Problems.UseLINQForDistinct();
    }
}

class Problems
{
    public static void UseLINQToFilter()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
    public static void UseLINQToSort()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Mango", "Pineapple" };
        var sortedFruits = fruits.OrderBy(fruit => fruit);
        Console.WriteLine("Sorted fruits:");
        foreach (var fruit in sortedFruits)
        {
            Console.WriteLine(fruit);
        }
    }
    public static void UseLINQToSelect()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Jane", Age = 25 },
            new Person { Name = "Bob", Age = 40 }
        };
        var names = people.Select(person => person.Name);
        Console.WriteLine("Names:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
    public static void UseLINQToGroup()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Jane", Age = 25 },
            new Person { Name = "Bob", Age = 40 }
        };
        var groupedByAge = people.GroupBy(person => person.Age);
        foreach (var group in groupedByAge)
        {
            Console.WriteLine($"People aged {group.Key}:");
            foreach (var person in group)
            {
                Console.WriteLine($"- {person.Name}");
            }
        }
    }
    public static void UseLINQToJoin()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "John", City = "New York" },
            new Person { Name = "Jane", City = "Los Angeles" }
        };
        List<City> cities = new List<City>
        {
            new City { Name = "New York", Population = 8000000 },
            new City { Name = "Los Angeles", Population = 4000000 }
        };
        var joinedData = people.Join(cities,
                                     person => person.City,
                                     city => city.Name,
                                     (person, city) => new { personName = person.Name, city.Name, city.Population });
        foreach (var data in joinedData)
        {
            Console.WriteLine($"Person: {data.Name}, City: {data.Name}, Population: {data.Population}");
        }
    }
    public static void UseLINQToAggregate()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        var sum = numbers.Sum();
        var average = numbers.Average();
        Console.WriteLine($"Sum: {sum}, Average: {average}");
    }
    public static void UseLINQToFindElement()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        var foundNumber = numbers.FirstOrDefault(n => n > 3);
        Console.WriteLine($"First number greater than 3: {foundNumber}");
    }
    public static void UseLINQWithAnonymousTypes()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Jane", Age = 25 },
            new Person { Name = "Bob", Age = 40 }
        };
        var anonymousData = people.Select(person => new { person.Name, person.Age });
        foreach (var data in anonymousData)
        {
            Console.WriteLine($"Name: {data.Name}, Age: {data.Age}");
        }
    }
    public static void UseLINQWithCollections()
    {
        List<int> numbers1 = new List<int> { 1, 2, 3 };
        List<int> numbers2 = new List<int> { 3, 4, 5 };
        var union = numbers1.Union(numbers2);
        Console.WriteLine("Union of numbers:");
        foreach (var number in union)
        {
            Console.WriteLine(number);
        }
    }
    public static void UseLINQForDistinct()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 5, 6, 6, 7, 8, 9, 10 };
        var distinctNumbers = numbers.Distinct();
        Console.WriteLine("Distinct numbers:");
        foreach (var number in distinctNumbers)
        {
            Console.WriteLine(number);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
    }
}
