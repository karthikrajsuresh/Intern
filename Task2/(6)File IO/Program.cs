using System;
using System.IO;

class problems
{
    public static void ReadTextFromFile()
    {
        string text = File.ReadAllText("example.txt");
        Console.WriteLine(text);
    }
    public static void WriteTextToFile()
    {
        string text = "This is some text to write to a file.";
        File.WriteAllText("example.txt", text);
        Console.WriteLine("Text written to file successfully.");
    }
    public static void AppendTextToFile()
    {
        string text = "This text will be appended to the file.";
        File.AppendAllText("example.txt", text);
        Console.WriteLine("Text appended to file successfully.");
    }
    public static void CopyFile()
    {
        File.Copy("example.txt", "example_copy.txt", true);
        Console.WriteLine("File copied successfully.");
    }
    public static void DeleteFile()
    {
        File.Delete("example.txt");
        Console.WriteLine("File deleted successfully.");
    }
    public static void ReadCsvFile()
    {
        string[] lines = File.ReadAllLines("example.csv");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    public static void WriteCsvFile()
    {
        string[] lines = { "Name, Age", "John, 30", "Jane, 25" };
        File.WriteAllLines("example.csv", lines);
        Console.WriteLine("CSV file written successfully.");
    }
    public static void ReadJsonFile()
    {
        string json = File.ReadAllText("example.json");
        dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
        Console.WriteLine(jsonObj);
    }
    public static void WriteJsonFile()
    {
        var jsonObj = new { Name = "John", Age = 30 };
        string json = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText("example.json", json);
        Console.WriteLine("JSON file written successfully.");
    }
    public static void HandleFileNotFound()
    {
        try
        {
            string text = File.ReadAllText("nonexistent.txt");
            Console.WriteLine(text);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File not found: {ex.Message}");
        }
    }
}
