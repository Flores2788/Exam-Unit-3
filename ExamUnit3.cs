using System;
public class ExamUnit3
{
    public int Square(int num)
    {
        return num * num;
    }

    public double InchesToMillimeters(double inches)
    {
        return inches * 25.4;
    }

    public static void Main(string[] args)
    {
      //testing the methods
        ExamUnit3 exam = new ExamUnit3();
        Console.WriteLine(exam.Square(5));
        Console.WriteLine(exam.InchesToMillimeters(5));
    }
}
