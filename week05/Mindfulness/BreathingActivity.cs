class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "Relax by breathing in and out slowly";
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);
            Console.Write("\nNow breathe out... ");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
    }
}