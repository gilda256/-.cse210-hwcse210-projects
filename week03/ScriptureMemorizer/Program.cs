using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference ("John", 3, 16);
        string text ="For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        var scripture = new Scripture (reference , text);

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");

            string userInput = Console .ReadLine();

            if (userInput.ToLower()== "quit")
            break;

            scripture.HideRandomWords(2);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture .GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program will now finish.");
                break;
            }
        }
    }
}