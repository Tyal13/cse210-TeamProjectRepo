using System;

// Author(s): [initials]
// See Program.cs for full team list and references.

namespace ScriptureMemorizer;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Single-verse constructor, e.g. Proverbs 3:5
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    // Verse-range constructor, e.g. Proverbs 3:5-6
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        // TODO: return "Book Chapter:Verse" or "Book Chapter:Start-End"
        throw new NotImplementedException();
    }
}
