using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Problem1_PrintHelloWorld();
        Problem2_GreetUser();
        Problem3_CalculateSum();
        Problem4_CheckEvenOrOdd();
        Problem5_FindLargestNumber();
        Problem6_PrintFirst10NaturalNumbers();
        Problem7_CalculateFactorial();
        Problem8_PrintFibonacciSeries();
        Problem9_ReverseString();
        Problem10_CheckPalindrome();
    }

    static void Problem1_PrintHelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }

    static void Problem2_GreetUser()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }

    static void Problem3_CalculateSum()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine($"Sum of {num1} and {num2} is {sum}");
    }

    static void Problem4_CheckEvenOrOdd()
    {
        Console.WriteLine("enter any number");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd");
        }
    }

    static void Problem5_FindLargestNumber()
    {
        Console.Write("Enter three numbers separated by spaces: ");
        string[] input = Console.ReadLine().Split();
        int largest = input.Max(num => int.Parse(num));
        Console.WriteLine($"The largest number is: {largest}");
    }

    static void Problem6_PrintFirst10NaturalNumbers()
    {
        Console.WriteLine("The First 10 natural numbers are:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void Problem7_CalculateFactorial()
    {
        Console.Write("Enter a number to calculate its factorial: ");
        int number = int.Parse(Console.ReadLine());

        int factorial = CalculateFactorial(number);

        Console.WriteLine($"Factorial of {number} is {factorial}");
    }
    static int CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }

    static void Problem8_PrintFibonacciSeries()
    {
        Console.Write("Enter the number of terms in Fibonacci series: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");

        int first = 0, second = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(first + " ");

            int next = first + second;
            first = second;
            second = next;
        }
        Console.WriteLine();
    }

    static void Problem9_ReverseString()
    {
        Console.Write("Enter a string to reverse: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        Console.WriteLine("Reversed string: " + reversedString);
    }

    static void Problem10_CheckPalindrome()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string cleanedInput = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        bool isPalindrome = true;
        for (int i = 0; i < cleanedInput.Length / 2; i++)
        {
            if (cleanedInput[i] != cleanedInput[cleanedInput.Length- i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
            Console.WriteLine("The input is a palindrome.");
        else
            Console.WriteLine("The input is not a palindrome.");
    }
}