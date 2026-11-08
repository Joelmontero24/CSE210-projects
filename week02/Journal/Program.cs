using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int userChoice = 0;

        Console.WriteLine("Welcome to the Journal Program!\n");

        while (userChoice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string responseString = Console.ReadLine();
            
            if (int.TryParse(responseString, out userChoice))
            {
                switch (userChoice)
                {
                    case 1:
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"\n{prompt}");
                        Console.Write("> ");
                        string entryText = Console.ReadLine();
                        string dateText = DateTime.Now.ToShortDateString();

                        Entry newEntry = new Entry(dateText, prompt, entryText);
                        theJournal.AddEntry(newEntry);
                        Console.WriteLine("Entry added successfully!\n");
                        break;

                    case 2:
                        theJournal.DisplayAll();
                        break;

                    case 3:
                        Console.Write("What is the filename? ");
                        string saveFilename = Console.ReadLine();
                        theJournal.SaveToFile(saveFilename);
                        break;

                    case 4:
                        Console.Write("What is the filename? ");
                        string loadFilename = Console.ReadLine();
                        theJournal.LoadFromFile(loadFilename);
                        break;

                    case 5:
                        Console.WriteLine("\nGoodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 5.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }
        }
    }
}