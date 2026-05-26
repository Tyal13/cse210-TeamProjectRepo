using System;
using ScriptureMemorizer;

// Creativity / exceeding requirements:
// TODO: describe here what your version does beyond the core requirements
// (e.g. library of scriptures, loading from file, only hiding non-hidden words, etc.)

// Main loop — matches the team's design diagram:
//   GetScripture() and PromptUser() are the Input functions.
//   DisplayScripture() is the Output function.
//   Loop runs while is_running == true; quits when user types "quit"
//   or when every word in the scripture is hidden.

bool isRunning = true;
Scripture scripture = GetScripture();

while (isRunning)
{
    DisplayScripture(scripture);

    if (scripture.IsCompletelyHidden())
    {
        isRunning = false;
        break;
    }

    string prompt = PromptUser();
    if (prompt == "quit")
    {
        isRunning = false;
    }
    else
    {
        scripture.HideWord();
    }
}

// --- Input ---

static Scripture GetScripture()
{
    // TODO: build and return a Scripture. For core requirements a single
    // hard-coded scripture is fine. Stretch: load from a file or pick at random.
    Reference reference = new Reference("Proverbs", 3, 5, 6);
    string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding. " +
                  "In all thy ways acknowledge him, and he shall direct thy paths.";
    return new Scripture(reference, text);
}

static string PromptUser()
{
    Console.WriteLine();
    Console.Write("Press enter to continue or type 'quit' to finish: ");
    string input = Console.ReadLine();
    return input == null ? "" : input.Trim().ToLower();
}

// --- Output ---

static void DisplayScripture(Scripture scripture)
{
    Console.Clear();
    Console.WriteLine(scripture.GetDisplayText());
}
