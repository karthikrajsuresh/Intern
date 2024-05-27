using System;
using System.Collections.Generic;
using System.Linq;

class problem
{
    public static void DemonstrateList()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        list.Add(6);
        list.Remove(2);
        Console.WriteLine("List contents: " + string.Join(", ", list));
    }
    public static void DictionaryCRUD()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary["one"] = 1;
        dictionary["two"] = 2;
        dictionary["three"] = 3;
        dictionary["two"] = 22;
        dictionary.Remove("three");

        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
    public static void SimulateWaitingLine()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Person 1");
        queue.Enqueue("Person 2");
        queue.Enqueue("Person 3");

        Console.WriteLine("Queue contents:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
    public static void ReverseStringWithStack()
    {
        Stack<char> stack = new Stack<char>();
        string str = "hello";

        foreach (char c in str)
        {
            stack.Push(c);
        }

        Console.Write("Reversed string: ");
        while (stack.Count > 0)
        {
            Console.Write(stack.Pop());
        }
        Console.WriteLine();
    }
    public static void DemonstrateHashSet()
    {
        HashSet<int> hashSet = new HashSet<int> { 1, 2, 3, 4, 5, 5, 6 };
        Console.WriteLine("HashSet contents: " + string.Join(", ", hashSet));
    }
    public class GenericClass<T>
    {
        private T data;

        public GenericClass(T value)
        {
            data = value;
        }

        public void Display()
        {
            Console.WriteLine("Data: " + data);
        }
    }
    public static void DemonstrateSortedList()
    {
        SortedList<string, int> sortedList = new SortedList<string, int>();
        sortedList["third"] = 3;
        sortedList["first"] = 1;
        sortedList["second"] = 2;

        Console.WriteLine("SortedList contents:");
        foreach (var kvp in sortedList)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
    public static void DemonstrateLinkedList()
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);

        Console.WriteLine("LinkedList contents:");
        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }
    }
    public static void WordFrequency()
    {
        string text = "hello world hello";
        string[] words = text.Split(' ');
        Dictionary<string, int> frequency = words.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

        Console.WriteLine("Word frequency:");
        foreach (var kvp in frequency)
        {
            Console.WriteLine($"Word: {kvp.Key}, Frequency: {kvp.Value}");
        }
    }
    public static void DemonstrateObservableCollection()
    {
        var collection = new System.Collections.ObjectModel.ObservableCollection<string>();
        collection.CollectionChanged += (sender, e) =>
        {
            Console.WriteLine($"Action: {e.Action}, New items count: {e.NewItems?.Count}, Old items count: {e.OldItems?.Count}");
        };

        collection.Add("Item 1");
        collection.Add("Item 2");
        collection.Remove("Item 1");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Section 4 - Problems 31 to 40\n");

        problem.DemonstrateList();
        problem.DictionaryCRUD();
        problem.SimulateWaitingLine();
        problem.ReverseStringWithStack();
        problem.DemonstrateHashSet();

        var genericInstance = new   problem.GenericClass<int>(10);
        genericInstance.Display();

        problem.DemonstrateSortedList();
        problem.DemonstrateLinkedList();
        problem.WordFrequency();
        problem.DemonstrateObservableCollection();
    }
}
