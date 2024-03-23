using System;

public class Task1
{
    public static void Main(string[] args)
    {
        
        Task1 exam = new Task1();
        Console.WriteLine(exam.Square(5));
        Console.WriteLine(exam.InchesToMillimeters(5));
        Console.WriteLine(exam.SquareRoot(5));
        Console.WriteLine(exam.Cube(5));
        Console.WriteLine(exam.CircleArea(5));
        Console.WriteLine(exam.Greet("Robert Plant"));
    }

    public int Square(int num)
    {
        return num * num;
    }

    public double InchesToMillimeters(double inches)
    {
        return inches * 25.4;
    }

    public double SquareRoot(double num)
    {
        return Math.Sqrt(num);
    }

    public int Cube(int num)
    {
        return num * num * num;
    }

    public double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
    
    public string Greet(string name)
    {
        return "Hello, " + name + "!";
    }    
    
}

