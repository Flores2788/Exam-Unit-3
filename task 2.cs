using System.Collections.Generic;
using System.IO;
using System.Text.Json;

var task = new Task2();
var filePath = "/Users/flores/Documents/Programming/Exam/arrays.json"; 
var flattenedArray = task.ReadAndFlattenJsonFile(filePath);
public class Task2
{
    public static void FlattenNumbers()
    {
        Task2 task = new Task2();
        string filePath = "/Users/flores/Documents/Programming/Exam/arrays.json"; 
        List<int> data = task.ReadAndFlattenJsonFile(filePath);

      
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }

    public List<int> ReadAndFlattenJsonFile(string filePath)
    {
        var jsonString = File.ReadAllText(filePath);
        var nestedArray = JsonSerializer.Deserialize<List<object>>(jsonString);
        
        if (nestedArray == null)
        {
            throw new ArgumentNullException(nameof(nestedArray));
        }
        
        return FlattenArray(nestedArray);
    }

    private List<int> FlattenArray(List<object> nestedArray)
    {
           if (nestedArray == null)
    {
        throw new ArgumentNullException(nameof(nestedArray));
    }
       
        var flattenedArray = new List<int>();

        foreach (var item in nestedArray)
        {
            if (item is List<object> sublist)
            {
                flattenedArray.AddRange(FlattenArray(sublist));
            }
            else if (item is int number)
            {
                flattenedArray.Add(number);
            }
        }

        return flattenedArray;
    }
    
}
