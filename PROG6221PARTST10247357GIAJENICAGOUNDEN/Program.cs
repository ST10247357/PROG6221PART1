namespace PROG6221PARTST10247357GIAJENICAGOUNDEN
{
    internal class Program
    {
        // Public static variables to store user's name and user's replies
        public static string reply = "";
        public static string moreAssistance = "";
        // Boolean variables to control the conversation flow
        public static bool keepAsking = true;
        public static bool validResponse = false;
        static void Main(string[] args)
        {
            // Display the bot's logo
            IntroductionUI.Logo();

            // Play a welcome audio message
            IntroductionUI.AudioWelcomeMessage();
            Thread.Sleep(11000);// Pauses the current thread for 7000 milliseconds (which is equal to 7 seconds).
            Console.WriteLine(""); // Leave a line

            // Display the welcome message
            IntroductionUI.WelcomeMessage();
            Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
            Console.WriteLine(""); // Leave a line

            // Get the user's name
            UserName.Name();
            Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
            Console.WriteLine(""); // Leave a line

            // Display a personalized welcome message from the bot
            Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
            Console.WriteLine($"Assistant: Welcome {UserName.name}!");
            Console.ResetColor();// Changes the colour back to white for the user's input

            // Main loop to keep asking the user for assistance until they choose to exit
            while (keepAsking)
            {
                try
                {
                    Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                    Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                    Console.WriteLine("Assistant: How can I assist you?");
                    Console.ResetColor();// Changes the colour back to white for the user's input
                    Console.Write($"{UserName.name}: ");
                    reply = Console.ReadLine();
                    Console.WriteLine(""); // Leave a line

                    // Check if the user's input is empty
                    if (string.IsNullOrWhiteSpace(reply))
                    {
                        throw new ArgumentException("Your input cannot be empty. Please type something.");
                    }

                    // Check user's reply for specific keywords and provide responses from the dictionary
                    if (reply.Contains("how are you", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine("Assitant: I'm doing well.");
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("purpose", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine("Assistant: My purpose is to help you stay informed and safe in the digital world.I provide cybersecurity tips, answer questions about online threats, and guide you on best practices to protect your data and devices.");
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("can i ask you", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine("Assistant: You can ask me about anything related to cybersecurity awareness.This includes topics like phishing, password security, social engineering, malware, safe browsing habits, mobile security, and how to protect your personal or organizational data.");
                        Console.ResetColor();// Changes the colour back to white for the user's input
                        Console.WriteLine(""); // Leave a line

                    }
                    else if (reply.Contains("phishing", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Phishing";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                           // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input

                    }
                    else if (reply.Contains("safe browsing", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Safe Browsing";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                           // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("password safety", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Password Safety";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                           // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input



                    }
                    else if (reply.Contains("malware", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Malware";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                           // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input



                    }
                    else if (reply.Contains("firewalls", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Firewalls";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                           // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input



                    }
                    else if (reply.Contains("two-factor authentication", StringComparison.OrdinalIgnoreCase) || reply.Contains("2fa", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Two-Factor Authentication";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                           // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("social engineering", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Social Engineering";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                           // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("software updates", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Software Updates";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                           // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("data encryption", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Data Encryption";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                           // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else if (reply.Contains("network security", StringComparison.OrdinalIgnoreCase))
                    {
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        string ans = "Network Security";
                        Console.ForegroundColor = ConsoleColor.DarkGray;// Changes the colour of the bot's input
                        Console.WriteLine($"Assistant: {CyberSecurityTopics.Topics[ans]}");// Writes a line to the console. It uses string interpolation to embed the value associated with
                                                                                           // the key stored in the 'ans' variable from the 'cyberSecurity' dictionary into the output string.
                        Console.ResetColor();// Changes the colour back to white for the user's input


                    }
                    else
                    {
                        // If the bot doesn't understand the input, provide a list of available topics
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        Console.ForegroundColor = ConsoleColor.Red;// Changes the colour of the error message
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");

                        Console.WriteLine("Assistant: I'm sorry, I didn't understand that. Please try asking about one of the following cybersecurity topics:");
                        Console.WriteLine(""); // Leave a line
                        Thread.Sleep(700);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                        foreach (var topic in CyberSecurityTopics.Topics.Keys)
                        {
                            Console.WriteLine(topic);
                        }
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine(""); // Leave a line
                        Console.ResetColor();// Changes the colour back to white for the user's input
                        Console.WriteLine(""); // Leave a line
                    }

                    // Ask the user if they need more assistance
                    ContinueOrExit();

                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during user input
                    Console.ForegroundColor = ConsoleColor.Red;// Changes the colour of the error message
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"Assistant: {ex.Message}");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(""); // Leave a line
                    Console.ResetColor();// Changes the colour back to white for the user's input


                }
            }
        }

        public static void ContinueOrExit()
        {
            validResponse = false; // RESET this every time the method runs

            while (!validResponse)
            {
                Thread.Sleep(700);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Assistant: Do you need more assistance? (yes/no)");
                Console.ResetColor();
                Thread.Sleep(700);
                Console.Write($"{UserName.name}: ");
                moreAssistance = Console.ReadLine();
                Console.WriteLine("");

                if (string.IsNullOrWhiteSpace(moreAssistance))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Assistant: Please type 'yes' to continue or 'no' to exit.");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.ResetColor();
                    continue;
                }

                if (moreAssistance.Contains("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Assistant: Thank you! Stay safe online.");
                    Thread.Sleep(1500);// Pauses the current thread for 700 milliseconds (which is equal to 0.7 seconds).
                    Console.ResetColor();
                    keepAsking = false;
                    validResponse = true;
                }
                else if (moreAssistance.Contains("yes", StringComparison.OrdinalIgnoreCase))
                {
                    validResponse = true; // This lets the main loop continue asking
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Assistant: Please enter 'yes' or 'no'.");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.ResetColor();
                }
            }
        }
    }
}
/*
 Name: Gia Jenica Gounden
 Student Number: st10247357
 Part 1

 References:
 ASCII Art Archive, 2025. Image to ASCII art, Image to ASCII: Free ASCII Art Converter.[online] Available at: <https://www.asciiart.eu/image-to-ascii> [Accessed 16 April 2025]. 
 Manwani, H. 2021. How to create and use the dictionary in C#, How to create and use the Dictionary in C#.[online] Available at: <https://www.loginradius.com/blog/engineering/how-to-create-and-use-dictionary-csharp/> [Accessed 16 April 2025]. 
 Tutorialsteacher, 2025. C# dictionary, C# - Dictionary.[online] Available at: <https://www.tutorialsteacher.com/csharp/csharp-dictionary> [Accessed 16 April 2025].  
 Moore, M. 2025. Top cybersecurity threats [2025]. University of San Diego Online Degrees, [Blog] 23 January. Available at: <https://onlinedegrees.sandiego.edu/top-cyber-security-threats/#:~:text=Malware%20continues%20to%20be%20prevalent,to%20steal%20or%20manipulate%20information> [Accessed 16 April 2025]. 
 Lindemulder, G. and Kosinski, M. 2024. What is cybersecurity?. [online] Available at: <https://www.ibm.com/think/topics/cybersecurity#:~:text=a%20single%20console.-,Common%20cybersecurity%20threats,Ransomware> [Accessed 16 April 2025].  
 pngtree, 2025. Bots Clipart Vector, Chatbot Linear Icon Chat Bot, Instant, Headset, Sign PNG Image For Free Download. [image online] Available at: <https://pin.it/6VdvJjW5Q> [Accessed 16 April 2025].
 ElevenLabs, 2025. Text to Speech with high quality, human-like AI voice generator. [online] Available at: <https://elevenlabs.io/text-to-speech?utm_source=google&utm_medium=cpc&utm_campaign=t2_nonbrandsearch_voicegen_english&utm_id=21540667164&utm_term=ai%20voice%20generator%20free&utm_content=voicegen_exact&gad_source=1&gclid=Cj0KCQjwh_i_BhCzARIsANimeoF2CE6L3sRz2osNqpdO1qvXk4ZHehWM23jMgkIlZ7oMIY-XldtowmkaAoJ3EALw_wcB> [Accessed 16 April 2025].
 
*/
