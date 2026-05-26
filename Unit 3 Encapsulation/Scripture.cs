using System;

namespace ScriptureMemorizer;

public class Scripture
{
    private Reference _reference;
    private Passage _passage;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _passage = new Passage(text);
    }

    // Top of the cascade: Scripture.HideWord() -> Passage.HideWord() -> Word.HideWord()
    // Called once per Enter press from the main loop. Hides a few words per call.
    public void HideWord()
    {
        // TODO: call _passage.HideWord() a few times (e.g. 3) to hide a few words
        throw new NotImplementedException();
    }

    public bool IsCompletelyHidden()
    {
        // TODO: delegate to _passage.IsCompletelyHidden()
        throw new NotImplementedException();
    }

    public string GetDisplayText()
    {
        // TODO: return "<reference display>\n<passage display>"
        throw new NotImplementedException();
    }
}
