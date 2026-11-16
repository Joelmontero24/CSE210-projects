using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        PopulateLibrary();
    }

    private void PopulateLibrary()
    {

        Reference ref1 = new Reference("John", 3, 16);
        _scriptures.Add(new Scripture(ref1, "For God so loved the world..."));

       
        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        _scriptures.Add(new Scripture(ref2, "Trust in the Lord with all thine heart..."));

    
        Reference ref3 = new Reference("Philippians", 4, 13);
        _scriptures.Add(new Scripture(ref3, "I can do all things through Christ..."));
    }

    
    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}