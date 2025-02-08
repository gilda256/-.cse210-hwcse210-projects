class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone",
        "Think of a time you did something difficult",
        "Think of a time you helped someone",
        "Think of a truly selfless act you did"
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel afterward?",
        "What made this different?",
        "What did you learn?",
        "How can you apply this?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "Reflect on meaningful experiences";
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private void DisplayQuestions()
    {
        Console.Write($"\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write($"\nYou may begin in:");
        ShowCountDown(5);
        Console.Clear();
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            
            
            Console.Write($"\n{GetRandomQuestion()} ");
            ShowSpinner(5);
        }
    }
}
