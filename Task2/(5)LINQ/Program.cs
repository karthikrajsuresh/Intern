using System;
using System.Collections.Generic;
using System.Linq;

class problem
{
    public static void BasicLinqOperations()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
    public static void LinqFilterElements()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
        var filteredFruits = fruits.Where(f => f.StartsWith("A"));
        Console.WriteLine("Fruits starting with 'A':");
        foreach (var fruit in filteredFruits)
        {
            Console.WriteLine(fruit);
        }
    }
    public static void LinqSortElements()
    {
        List<string> fruits = new List<string> { "Banana", "Apple", "Elderberry", "Cherry", "Date" };
        var sortedFruits = fruits.OrderBy(f => f);
        Console.WriteLine("Sorted fruits:");
        foreach (var fruit in sortedFruits)
        {
            Console.WriteLine(fruit);
        }
    }
    public static void LinqMaxMinElements()
    {
        int[] numbers = { 5, 3, 9, 1, 7 };
        int max = numbers.Max();
        int min = numbers.Min();
        Console.WriteLine($"Maximum: {max}, Minimum: {min}");
    }
    public static void LinqGroupElements()
    {
        string[] words = { "apple", "banana", "cherry", "avocado", "blueberry" };
        var groupedWords = words.GroupBy(w => w[0]);
        foreach (var group in groupedWords)
        {
            Console.WriteLine($"Words starting with '{group.Key}':");
            foreach (var word in group)
            {
                Console.WriteLine(word);
            }
        }
    }
    public static void LinqJoinCollections()
    {
        List<int> ids = new List<int> { 1, 2, 3 };
        List<string> names = new List<string> { "John", "Jane", "Jack" };

        var joined = ids.Join(names,
            id => id,
            name => names.IndexOf(name) + 1,
            (id, name) => new { Id = id, Name = name });

        Console.WriteLine("Joined collections:");
        foreach (var item in joined)
        {
            Console.WriteLine($"ID: {item.Id}, Name: {item.Name}");
        }
    }
    public static void LinqSelectFields()
    {
        var people = new List<Person>
        {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Jane", Age = 25 }
        };

        var names = people.Select(p => p.Name);
        Console.WriteLine("Names of people:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
    public static void LinqSumAndAverage()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = numbers.Sum();
        double average = numbers.Average();
        Console.WriteLine($"Sum: {sum}, Average: {average}");
    }
    public static void LinqDistinctElements()
    {
        int[] numbers = { 1, 2, 2, 3, 3, 4, 5 };
        var distinctNumbers = numbers.Distinct();
        Console.WriteLine("Distinct numbers:");
        foreach (var num in distinctNumbers)
        {
            Console.WriteLine(num);
        }
    }
    public static void LinqWithComplexDataStructures()
    {
        var nestedLists = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9 }
        };

        var allNumbers = nestedLists.SelectMany(list => list);
        Console.WriteLine("All numbers in nested lists:");
        foreach (var num in allNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        
        problem.BasicLinqOperations();
        problem.LinqFilterElements();
        problem.LinqSortElements();
        problem.LinqMaxMinElements();
        problem.LinqGroupElements();
        problem.LinqJoinCollections();
        problem.LinqSelectFields();
        problem.LinqSumAndAverage();
        problem.LinqDistinctElements();
        problem.LinqWithComplexDataStructures();
    }
}

