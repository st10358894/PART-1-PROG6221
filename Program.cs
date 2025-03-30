// See https://aka.ms/new-console-template for more information
using System;
using System.Speech.Synthesis;

class CybersecurityChatbot
{
    static void Main()
    {
        PlayVoiceGreeting();
        DisplayAsciiArt();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Hello! What's your name? ");
        Console.ResetColor();
        string userName = Console.ReadLine();
        Console.WriteLine($"\nWelcome, {userName}! I'm here to help you stay safe online.");
        Console.WriteLine("How are you today?");
        string userResponse = Console.ReadLine();
        RespondToUserMood(userResponse);
    }

    static void PlayVoiceGreeting()
    {
        try
        {
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                synthesizer.SelectVoice("Microsoft David Desktop");
                synthesizer.Speak("Hello! Welcome to the Cybersecurity Awareness Chatbot.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("(Speech synthesis failed: " + e.Message + ")");
        }
    }

    static void DisplayAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
        /$$$$$$            /$$                               
       /$$__  $$          | $$                               
      | $$  \ $$  /$$$$$$ | $$  /$$$$$$   /$$$$$$  /$$   /$$
      | /$$__  $$| $$ /$$__  $$ /$$__  $$| $$  | $$
      | $$__  $$| $$$$$$$$| $$| $$$$$$$$| $$$$$$$$| $$  | $$
      | $$  | $$| $$_____/| $$| $$_____/| $$_____/| $$  | $$
      | $$  | $$|  $$$$$$$| $$|  $$$$$$$|  $$$$$$$| 
      |__/  |__/ \_______/|__/ \_______/ \_______/ \____  $$
                                                  /$$  | $$
                                                 |  $$$$$$/
                                                  \______/
        ");
        Console.ResetColor();
    }

    static void RespondToUserMood(string input)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Thanks for sharing how you're feeling today.");
        Console.ResetColor();
    }
}
