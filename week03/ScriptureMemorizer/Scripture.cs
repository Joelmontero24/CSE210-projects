using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string item in wordArray)
        {
            Word newWord = new Word(item);
            _words.Add(newWord);
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        if (IsCompletelyHidden())
        {
            return;
        }

        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count);
            Word wordToHide = _words[index];

            if (!wordToHide.IsHidden())
            {
                wordToHide.Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string textResult = "";
        foreach (Word word in _words)
        {
            textResult += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {textResult.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; 
            }
        }
        return true; 
    }
}
