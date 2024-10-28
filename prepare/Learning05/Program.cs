using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment("Brayden", "MATH 341", "Section 3.1", "Problems 1-12");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        Console.WriteLine("");

        WritingAssignment writing1 = new WritingAssignment("Brayden", "Foundations of the Restoration", "Notable Events of the Restoration");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}