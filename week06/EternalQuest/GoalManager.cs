public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _score;
    public void Start()
    {
        bool keepRunning = true;

        do
        {
            Console.WriteLine($"\nYou now have {_score} points."); 
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();
        
            if (choice == "1")
            {
                CreateGoal();
            } 
            else if (choice == "2") 
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            } 
            else if (choice == "4")
            {
                LoadGoals();
            } 
            else if (choice == "5")
            {
                RecordEvent();
            } 
            else if (choice == "6")
            {
                keepRunning = false;
            } 
        
        } while (keepRunning);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
             Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }
            
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
    {
        Goal goal = goals[i];
        string status = goal.IsComplete() ? "[X]" : "[]";
        Console.WriteLine($"{i + 1}. {status} {goal.GetName()} ({goal.GetDescription()})");
    }
            
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1.Simple Goal");
        Console.WriteLine("2.Ethernal Goal");
        Console.WriteLine("3.Checklist Goal");
        Console.Write("Which type of goal would you like to create: ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is the short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

            if(type == "1")
            {
                goals.Add(new SimpleGoal(name, description, points));
            }
                
            else if (type == "2")
            {
                goals.Add(new EternalGoal(name, description, points));
            }
        
            else if (type == "3")
            {
                 Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                 int target = int.Parse(Console.ReadLine());
        
                 Console.Write("What is the bonus for accomplishing it that many times? ");
                 int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, target, bonus));
            }
        
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            Goal goal = goals[index];
            int earnedPoints = goal._points;
            int bonus = 0;

            goal.RecordEvent();
            
            if (goal is ChecklistGoal checklist && checklist.IsComplete())
        {
            bonus = checklist.GetBonus();
            earnedPoints += bonus;
        }

        _score += earnedPoints;

        Console.WriteLine($"\nCongratulations! You have earned {earnedPoints} points!");
        if (bonus>0)
        {
            Console.WriteLine($"You now have {bonus} points");
        }
    }
}

    public void SaveGoals()
    { 
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in goals)
            {
               outputFile.WriteLine(goal.GetStringRepresentation());
            }
                
        }
    }

    public void LoadGoals()
    {

        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();

        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                switch (parts[0])
                {
                    case "SimpleGoal":
                        goals.Add(new SimpleGoal(
                            parts[1], 
                            parts[2], 
                            int.Parse(parts[3]), 
                            bool.Parse(parts[4])));
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(
                            parts[1], 
                            parts[2], 
                            int.Parse(parts[3])));
                        break;
                    case "ChecklistGoal":
                        goals.Add(new ChecklistGoal(
                            parts[1], 
                            parts[2], 
                            int.Parse(parts[3]), 
                            int.Parse(parts[4]), 
                            int.Parse(parts[5]), 
                            int.Parse(parts[6])));
                        break;
                }
            }
        }
    }
}

