namespace conditions;

class Program
{
    static void Main(string[] args)
    {
        double score;
        Console.Write("Enter your score: ");
        score = double.Parse(Console.ReadLine()); 
        Console.WriteLine("Your score: {0}",score);
        if (score > 100)
        { 
            Console.WriteLine("Error: score is greater than 100!");
        }
        else if (score < 0) 
        {
            Console.WriteLine("Error: score is less than 0!");
        }
        else if (score >= 50) 
        {
            Console.WriteLine("Pass!");
        }
        else 
        {
            Console.WriteLine("Fail!");
        }
    }    
}

