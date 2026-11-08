public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public string GetDate() => _date;
    public string GetPromptText() => _promptText;
    public string GetEntryText() => _entryText;

    public void Display()
    {
        System.Console.WriteLine($"Date: {_date} — Prompt: {_promptText}");
        System.Console.WriteLine($"\"{_entryText}\"\n");
    }
}