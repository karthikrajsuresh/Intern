using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running exception handling examples:");
        Problems.HandleFileNotFound();
        Problems.HandleNullReference();
        Problems.UseTryCatchBlocks();
        Problems.UseFinallyBlock();
        Problems.CreateAndThrowCustomException();
        Problems.HandleMultipleExceptions();
        Problems.UseUsingStatement();
        Problems.UseExceptionFilters();
    }
}

class Problems
{
    public static void HandleFileNotFound()
    {
        try
        {
            string content = File.ReadAllText("nonexistentfile.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found exception handled.");
        }
    }

    public static void HandleNullReference()
    {
        try
        {
            string? text = null;
            if (text != null)
            {
                int length = text.Length;j
            }
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Null reference exception handled.");
        }
    }

    public static void UseTryCatchBlocks()
    {
        try
        {
            int[] numbers = new int[3];
            int value = numbers[4]; 
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range exception handled.");
        }
    }

    public static void UseFinallyBlock()
    {
        try
        {
            Console.WriteLine("Try block");
        }
        finally
        {
            Console.WriteLine("Finally block");
        }
    }
    public static void CreateAndThrowCustomException()
    {
        try
        {
            throw new CustomException("Custom exception occurred.");
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Custom exception handled: {ex.Message}");
        }
    }
    public static void HandleMultipleExceptions()
    {
        try
        {
            int[] numbers = new int[3];
            int value = numbers[4];
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range exception handled.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Other exception handled: {ex.Message}");
        }
    }
    public static void UseUsingStatement()
    {
        using (var stream = new StreamWriter("test.txt"))
        {
            stream.WriteLine("Using statement example.");
        }
    }
    public static void UseExceptionFilters()
    {
        try
        {
            int[] numbers = new int[3];
            int value = numbers[4];
        }
        catch (Exception ex) when (ex is IndexOutOfRangeException || ex is ArgumentNullException)
        {
            Console.WriteLine("Exception filtered and handled.");
        }
    }
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
}
