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

        Console.WriteLine("\nI'm RELEEY AI, your helpful assistant. I can assist you with various cybersecurity topics.");
        RunChatbot();
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

    static void RunChatbot()
    {
        while (true)
        {
            Console.WriteLine("\nSelect a topic:");
            Console.WriteLine("1. Introduction to Cybersecurity");
            Console.WriteLine("2. Password Safety");
            Console.WriteLine("3. Phishing");
            Console.WriteLine("4. Malware");
            Console.WriteLine("5. Exit");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter a number or type a topic: ");
            Console.ResetColor();
            string input = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a valid topic or number.");
                continue;
            }

            if (input == "exit" || input == "5")
            {
                Console.WriteLine("Goodbye! Stay safe online.");
                break;
            }

            RespondToUser(input);
        }
    }

    static void RespondToUser(string input)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        switch (input)
        {
            case "1":
            case "introduction to cybersecurity":
                Console.WriteLine("Cybersecurity is the practice of protecting electronic information, networks, and systems from unauthorized access, use, disclosure, disruption, modification, or destruction.");
                break;
            case "2":
            case "password safety":
                Console.WriteLine("Use at least 12 characters, mix upper/lowercase letters, numbers, and symbols. Avoid using easily guessable information like your name or birthdate.");
                break;
            case "3":
            case "phishing":
                Console.WriteLine("Phishing is a cyberattack where attackers trick you into revealing personal information, such as passwords or credit card numbers, by sending fake emails or messages that appear to be from a legitimate source.");
                break;
            case "4":
            case "malware":
                Console.WriteLine("Malware is short for 'malicious software.' It's a type of software that's designed to harm or exploit a computer system. Examples of malware include viruses, worms, and trojans.");
                break;
            default:
                Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                break;
        }
        Console.ResetColor();
    }

    static void RespondToUserMood(string input)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        string[] goodMoods = { "good", "great", "excellent", "well", "sharp", "wonderful" };
        string[] badMoods = { "bad", "not good", "sick", "tired", "sad", "depressed" };

        if (Array.Exists(goodMoods, mood => mood == input.ToLower()))
        {
            Console.WriteLine("That's wonderful to hear! I'm glad you're having a great day.");
        }
        else if (Array.Exists(badMoods, mood => mood == input.ToLower()))
        {
            Console.WriteLine("Sorry to hear that. Hopefully, our conversation will brighten your day a bit. If you need any help or just want to talk, I'm here to listen.");
        }
        else
        {
            Console.WriteLine("I'm not sure I understand. Could you please rephrase how you're feeling today?");
        }
        Console.ResetColor();
    }
}
