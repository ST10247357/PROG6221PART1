namespace PROG6221PARTST10247357GIAJENICAGOUNDEN
{
    internal class Program
    {
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
        }
    }
}
