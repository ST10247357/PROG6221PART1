# Cybersecurity Awareness Chatbot

This is a C# console application that simulates a chatbot for raising awareness about cybersecurity. The chatbot provides brief, accurate responses to user questions based on a dictionary of cybersecurity topics. It also includes a user-friendly experience with personalized greetings and interaction flow.

---

## Features

- Console-based chatbot in C#
- Personalized welcome and interaction
- Audio greeting using a `.wav` file
- Dictionary of cybersecurity topics
- Input validation and exception handling
- Option to continue or exit

---

## Setup Instructions

### Requirements

- Windows operating system
- Visual Studio 2022 or later
- .NET 6.0 SDK or higher
- `WelcomeAudio.wav` file in the root or output folder

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/cybersecurity-chatbot.git
   cd cybersecurity-chatbot
   
2. Open the solution file (.sln) in Visual Studio.

3. Ensure that BotAudio.wav is located in the project root or in the bin/Debug/net6.0/ directory.

4.Build and run the project:

- Press Ctrl + F5 or
- Click on "Start Without Debugging"

## How to Use

1. Launch the app.

2. Enter your name when prompted.

3. Ask the chatbot a question or type a keyword like:

- phishing
- password safety
- malware
- network security
- firewalls
- social engineering

4. The chatbot will respond using information stored in a dictionary.

5. The app will ask if you want more assistance.

- Type yes to continue
- Type no to exit

## Supported Topics

- Phishing
- Safe Browsing
- Password Safety
- Malware
- Firewalls
- Two-Factor Authentication
- Social Engineering
- Software Updates
- Data Encryption
- Network Security

## Project Structure

/CybersecurityChatbot
│
├── Program.cs
├── CyberSecurity.cs
├── IntroductionUI.cs
├── UserNameClass.cs
├── BotAudio.wav
└── README.md

## Sample Interaction

Bot: What is your name?
You: Alex

Bot: Welcome Alex!
Bot: How can I assist you?
Alex: Tell me about malware.

Bot: Malware is malicious software designed to harm or exploit any device, service, or network...

## References

ASCII Art Archive, 2025. Image to ASCII art, Image to ASCII: Free ASCII Art Converter.[online] Available at: <https://www.asciiart.eu/image-to-ascii> [Accessed 16 April 2025]. 
Manwani, H. 2021. How to create and use the dictionary in C#, How to create and use the Dictionary in C#.[online] Available at: <https://www.loginradius.com/blog/engineering/how-to-create-and-use-dictionary-csharp/> [Accessed 16 April 2025]. 
Tutorialsteacher, 2025. C# dictionary, C# - Dictionary.[online] Available at: <https://www.tutorialsteacher.com/csharp/csharp-dictionary> [Accessed 16 April 2025].  
Moore, M. 2025. Top cybersecurity threats [2025]. University of San Diego Online Degrees, [Blog] 23 January. Available at: <https://onlinedegrees.sandiego.edu/top-cyber-security-threats/#:~:text=Malware%20continues%20to%20be%20prevalent,to%20steal%20or%20manipulate%20information> [Accessed 16 April 2025]. 
Lindemulder, G. and Kosinski, M. 2024. What is cybersecurity?. [online] Available at: <https://www.ibm.com/think/topics/cybersecurity#:~:text=a%20single%20console.-,Common%20cybersecurity%20threats,Ransomware> [Accessed 16 April 2025].  
W3schools, 2025. C# Exceptions (Try..Catch). [online] Available at: <https://www.w3schools.com/cs/cs_exceptions.php> [Accessed 16 April 2025].

## Author
Gia Jenica Gounden
Student Number: st10247357
Project Module: PROG6221
Date: April 2025

## License
This project is provided for academic purposes only.






