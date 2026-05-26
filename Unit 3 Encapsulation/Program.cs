using System;
using ScriptureMemorizer;

// =============================================================================
// CSE 210 - Unit 03 Develop: Scripture Memorizer
// Team project (coding together with instructor permission).
//
// Team Members:
//   AH  - Adam Herrmann
//   XX  - [teammate name]
//   XX  - [teammate name]
//   XX  - [teammate name]
//
// Contributions (who worked on what):
//   AH  - [e.g. Program.cs main loop, Reference class]
//   XX  - [e.g. Scripture class, hide logic]
//   XX  - [e.g. Passage class]
//   XX  - [e.g. Word class, display formatting]
//
// References / things that helped us:
//   - Initial project scaffolding generated with Claude Code (Anthropic).
//   - BYU-I CSE 210 W06 assignment page (Scripture Memorizer).
//   - [add any tutorials, docs, Stack Overflow links, etc. used here]
//
// Creativity / exceeding requirements:
//   TODO: describe here what our version does beyond the core requirements
//   (e.g. library of scriptures, loading from file, only hiding non-hidden words, etc.)
// =============================================================================

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
