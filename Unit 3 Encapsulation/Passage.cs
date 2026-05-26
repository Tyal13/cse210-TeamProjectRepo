using System;
using System.Collections.Generic;

// Author(s): [initials]
// See Program.cs for full team list and references.

namespace ScriptureMemorizer;

// Holds the list of Word objects for a scripture's text.
// Sits between Scripture and Word in the HideWord() cascade.
public class Passage
{
    private List<Word> _words;

    public Passage(string text)
    {
        _words = new List<Word>();
        // TODO: split `text` on whitespace and add a Word for each token
    }

    // Called by Scripture.HideWord(). Picks a random word and tells it to hide.
    public void HideWord()
    {
        // TODO: pick a random index in _words and call _words[i].HideWord()
        // Core requirement: any word, even already hidden. Stretch: pick only un-hidden words.
        throw new NotImplementedException();
    }

    public bool IsCompletelyHidden()
    {
        // TODO: return true when every word in _words is hidden
        throw new NotImplementedException();
    }

    public string GetDisplayText()
    {
        // TODO: return each word's display text joined by spaces
        throw new NotImplementedException();
    }
}
