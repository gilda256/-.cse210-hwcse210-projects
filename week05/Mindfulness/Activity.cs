class Activity
{
    public string _name;
    public string _description;
    public int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in second, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
{
    DateTime endTime = DateTime.Now.AddSeconds(seconds);
    List<string> spinner = new List<string>();
    spinner.Add("|");
    spinner.Add("/");
    spinner.Add("-");
    spinner.Add("\\");

    int index = 0;

    while (DateTime.Now < endTime)
    {
        string s = spinner[index];
        Console.Write(s);
        Thread.Sleep(250);
        Console.Write("\b \b");
        
        index++;  
        if (index >= spinner.Count)  
        {
            index = 0; 
        }
    }
}
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
