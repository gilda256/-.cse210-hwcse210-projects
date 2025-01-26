using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator._prompts = new List<string>
        {
            "What is one thing I learned today that surprised or inspired me?",
            "Who made me feel appreciated or loved today, and how did they do it?",
            "What small achievement or progress am I proud of today?",
            "How did I make a positive impact on someone else's day today?",
            "If I could thank one person for something they did today, who would it be and why?",
        };
           Console.WriteLine("Welcome to the Journal program!");
           string userChoice;
    
        do
        {
            Console.WriteLine("Please select one of the following choices:\n");
            string options = "1. Write\n2. Display\n3. Load\n4. Save\n5. Quit";
            Console.WriteLine(options);
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Entry entry = new Entry();
                {
                    entry._date = dateText;
                    entry._promptText = promptGenerator.GetRandomPrompt();

                }
                

                Console.Write($"{entry._promptText}\n");
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
            }

            else if (userChoice == "2")
            {
                journal.DisplayAll();
            }

            else if (userChoice == "3")
            {
                Console.Write("Enter the filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);

            }

            else if (userChoice == "4")
            {
               Console.Write("Enter the filename to save to: ");
               string filename = Console.ReadLine();
               journal.SaveToFile(filename);
            }

           

        } while (userChoice != "5" );
         
    
    }
}