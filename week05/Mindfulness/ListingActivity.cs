class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you helped this week?",
        "When did you feel the Holy Ghost this month?",
        "Who are your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "List positive things in your life";
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        _count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
             _count++;
        }

        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Random rand = new Random();
        Console.WriteLine($"\n--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.Write("You may begin in:");
        ShowCountDown(5);
    }

    private List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        return list;
    }
}


