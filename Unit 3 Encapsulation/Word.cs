using System;

// Author(s): [initials]
// See Program.cs for full team list and references.

namespace ScriptureMemorizer;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Called from Passage.HideWord() (innermost step of the cascade).
    public void HideWord()
    {
        // TODO: mark this word as hidden
        throw new NotImplementedException();
    }

    public bool IsHidden()
    {
        // TODO: return hidden state
        throw new NotImplementedException();
    }

    public string GetDisplayText()
    {
        // TODO: return the word, or underscores of equal length if hidden
        throw new NotImplementedException();
    }
}
