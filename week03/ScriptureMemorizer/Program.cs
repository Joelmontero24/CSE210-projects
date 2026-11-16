/* Exceeding Requirements:
 * I Implemented a ScriptureLibrary class that holds a collection of scriptures 
 * and selects one at random each time the program runs,
 * to present to the user.
 */
 

using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            userInput = Console.ReadLine().Trim().ToLower();

            if (userInput != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram ended. Well done practicing!");
    }
}