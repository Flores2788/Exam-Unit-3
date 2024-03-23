using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;



public class Node
{
    public int value { get; set; }
    public Node left { get; set; }
    public Node right { get; set; }

}
public class Task3
{

    public static void Main()
    {
        var task = new Task3();
        var filePath = "nodes.json";
        var root = task.ReadJsonFile(filePath);
        var sum = task.CalculateSum(root);
        var deepestLevel = task.FindDeepestLevel(root);
        var nodeCount = task.CountNodes(root);
     
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Deepest Level: {deepestLevel}");
        Console.WriteLine($"Node Count: {nodeCount}");
    }
    
    public Node ReadJsonFile(string filePath)
    {
        var jsonString = File.ReadAllText(filePath);
        var root = JsonSerializer.Deserialize<Node>(jsonString);
        return root;
    }

    public int CalculateSum(Node node)
    {
        if (node == null)
        {
            return 0;
        }

        return node.value + CalculateSum(node.left) + CalculateSum(node.right);
    }

    public int FindDeepestLevel(Node node)
    {
        if (node == null)
        {
            return 0;
        }

        return 1 + Math.Max(FindDeepestLevel(node.left), FindDeepestLevel(node.right));
    }

    public int CountNodes(Node node)
    {
        if (node == null)
        {
            return 0;
        }

        return 1 + CountNodes(node.left) + CountNodes(node.right);
    }

    
}