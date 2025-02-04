using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        //assignment1.SetName("Samuen Bennett");
        //assignment1.SetTopic("Multiplication");
    
        
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Angel Moure", "Division", "Section 7.3", "Problems 8-19");
        //mathAssignment1.SetName("Samuel Bennett");
        //mathAssignment1.SetTopic("Multiplication");
        //mathAssignment1.SetTextbookSection("Section 7.3");
        //mathAssignment1.Setproblem("Problems 8-19");

        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II", "Mary Waters");
        //writingAssignment1.SetName("Mary Waters");
        //writingAssignment1.SetTopic("European History");
        //writingAssignment1.SetTitle("The Causes of World War II");
        //writingAssignment1.SetAuthor("Mary Waters");

        Console.WriteLine(writingAssignment1.GetWritingInformation());

    }
}