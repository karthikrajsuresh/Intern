using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Problem11_SimpleStack();
        Problem12_SimpleQueue();
        Problem13_FindMaximumElementInArray();
        Problem14_BubbleSort();
        Problem15_BinarySearch();
        Problem16_MergeSortedArrays();
        Problem17_FindSecondLargestElement();
        Problem18_CountElementOccurrences();
        Problem19_FindArrayIntersection();
        Problem20_RemoveDuplicatesFromArray();

    }
    static void Problem11_SimpleStack()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        while (stack.Count > 0)
        {
            int element = stack.Pop();
            Console.WriteLine($"Popped element: {element}");
        }
    }

    static void Problem12_SimpleQueue()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        int dequeuedItem1 = queue.Dequeue();
        int dequeuedItem2 = queue.Dequeue();
        Console.WriteLine($"Dequeued item 1: {dequeuedItem1}");
        Console.WriteLine($"Dequeued item 2: {dequeuedItem2}");
    }

    static void Problem13_FindMaximumElementInArray()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("The maximum element in the array is: " + max);
    }

    static void Problem14_BubbleSort()
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original array:");
        PrintArray(array);
        BubbleSort(array);
        Console.WriteLine("Sorted array:");
        PrintArray(array);
    }
    static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }
    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }

    static void Problem15_BinarySearch()
    {
        int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

        Console.Write("Enter the number to search for: ");
        int target = int.Parse(Console.ReadLine());

        int result = BinarySearch(sortedArray, target);

        if (result != -1)
        {
            Console.WriteLine($"Element found at index {result}.");
        }
        else
        {
            Console.WriteLine("Element not found in the array.");
        }
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid;
            }

            if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    static void Problem16_MergeSortedArrays()
    {
        int[] array1 = { 1, 3, 5, 7 };
        int[] array2 = { 2, 4, 6, 8 };

        int[] mergedArray = MergeSortedArrays(array1, array2);

        Console.WriteLine("Merged array:");
        foreach (int num in mergedArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];
        int i = 0, j = 0, k = 0;

        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                result[k++] = arr1[i++];
            }
            else
            {
                result[k++] = arr2[j++];
            }
        }

        while (i < arr1.Length)
        {
            result[k++] = arr1[i++];
        }

        while (j < arr2.Length)
        {
            result[k++] = arr2[j++];
        }

        return result;
    }

    static void Problem17_FindSecondLargestElement()
    {
        int[] array = { 10, 5, 20, 8, 30, 25 };

        if (array.Length < 2)
        {
            Console.WriteLine("Array must contain at least two elements.");
            return;
        }

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in array)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        foreach (int num in array)
        {
            if (num > secondLargest && num < largest)
            {
                secondLargest = num;
            }
        }

        if (secondLargest == int.MinValue)
        {
            Console.WriteLine("No second largest element found.");
        }
        else
        {
            Console.WriteLine($"The second largest element is {secondLargest}");
        }
    }

    static void Problem18_CountElementOccurrences()
    {
        int[] array = { 1, 2, 2, 3, 4, 4, 4, 5 };
        Dictionary<int, int> elementCounts = new Dictionary<int, int>();

        foreach (int element in array)
        {
            if (elementCounts.ContainsKey(element))
            {
                elementCounts[element]++;
            }
            else
            {
                elementCounts[element] = 1;
            }
        }

        Console.WriteLine("Element occurrences in the array:");
        foreach (var kvp in elementCounts)
        {
            Console.WriteLine($"Element {kvp.Key} occurs {kvp.Value} times.");
        }
    }

    static void Problem19_FindArrayIntersection()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 4, 5, 6, 7, 8 };

        int[] intersection = array1.Intersect(array2).ToArray();

        Console.WriteLine("Intersection of the two arrays:");
        foreach (var item in intersection)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Problem20_RemoveDuplicatesFromArray()
    {
        int[] array = { 1, 2, 3, 4, 4, 5, 6, 6, 7, 8, 9, 9 };
        Console.WriteLine("Original array:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        int[] uniqueArray = RemoveDuplicates(array);

        Console.WriteLine("Array after removing duplicates:");
        foreach (var item in uniqueArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static int[] RemoveDuplicates(int[] array)
    {
        HashSet<int> uniqueElements = new HashSet<int>(array);
        return uniqueElements.ToArray();
    }

}