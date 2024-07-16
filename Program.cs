using System;
using System.Windows.Forms; // Add this namespace for Clipboard

class Program
{
    [STAThread]
    static void Main()
    {
        bool exitRequested = false;

        do
        {
            Console.WriteLine("Enter the length of the password:");
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                string password = GeneratePassword(length);
                Console.WriteLine($"Generated Password: {password}");

                bool generateAnother = true;
                while (generateAnother)
                {
                    Console.WriteLine("Would you like to generate a different password? (Y/N)");
                    string response = Console.ReadLine().Trim().ToUpper();
                    generateAnother = response == "Y";
                    if (generateAnother)
                    {
                        length = AskForPasswordLength();
                        password = GeneratePassword(length);
                        Console.WriteLine($"Generated Password: {password}");
                    }
                }

                Console.WriteLine("Would you like to save this password to clipboard? (Y/N)");
                string saveToClipboard = Console.ReadLine().Trim().ToUpper();
                if (saveToClipboard == "Y")
                {
                    Clipboard.SetText(password);
                    Console.WriteLine("Password saved to clipboard.");
                }

                Console.WriteLine("Would you like to exit the application? (Y/N)");
                string exitResponse = Console.ReadLine().Trim().ToUpper();
                if (exitResponse == "Y")
                {
                    exitRequested = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (!exitRequested);
    }

    static int AskForPasswordLength()
    {
        int length;
        Console.WriteLine("Enter the new length of the password:");
        while (!int.TryParse(Console.ReadLine(), out length))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        return length;
    }

    static string GeneratePassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var random = new Random();
        var passwordChars = new char[length];

        for (int i = 0; i < length; i++)
        {
            passwordChars[i] = chars[random.Next(chars.Length)];
        }

        return new string(passwordChars);
    }
}
