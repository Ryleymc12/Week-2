using System;

namespace Week2Practical
{
    class Program
    {
        public static void Main(String[] args)
        {
            int option;

            // Use a do-while loop to keep showing the menu until the user selects 0
            do
            {
                // Call the PrintMenu method to show options
                PrintMenu();

                // Get the user's choice using InputOption method
                option = InputOption();

                // Call GetMessage method to get the greeting based on the option
                string message = GetMessage(option);

                // Display the message
                Console.WriteLine(message);

            } while (option != 0); // Loop will stop when option is 0 (Exit)
        }

        // Method to print the menu options
        static void PrintMenu()
        {
            Console.WriteLine("Please enter a valid option from below:");
            Console.WriteLine("1. Hello in French?");
            Console.WriteLine("2. Hello in Spanish?");
            Console.WriteLine("3. Hello in German?");
            Console.WriteLine("4. Hello in Italian?");
            Console.WriteLine("0. Exit application");
        }

        // Method to get user input and return it as an integer option
        static int InputOption()
        {
            int option = -1; // Default invalid option
            bool validInput = false; // Flag for input validation

            // Keep prompting the user until a valid input is provided
            while (!validInput)
            {
                try
                {
                    // Ask for user input
                    Console.Write("Please enter your choice: ");
                    string input = Console.ReadLine(); // Read input as string

                    // Attempt to convert the input to an integer
                    option = Convert.ToInt32(input);

                    // Validate if the input is within the allowed range
                    if (option >= 0 && option <= 4)
                    {
                        validInput = true; // Exit loop if input is valid
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a number between 0 and 4.");
                    }
                }
                catch (FormatException) // Catch any non-integer input
                {
                    Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
                }
                catch (Exception ex) // Catch any other unexpected errors
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }

            // Return the valid option to Main()
            return option;
        }

        // Method to return a greeting message based on the option chosen by the user
        static string GetMessage(int language)
        {
            switch (language)
            {
                case 0:
                    return "Goodbye"; // Exit message
                case 1:
                    return "Bonjour"; // French
                case 2:
                    return "Hola"; // Spanish
                case 3:
                    return "Hallo"; // German
                case 4:
                    return "Ciao"; // Italian
                default:
                    return "Please enter a valid option"; // In case of an invalid option
            }
        }
    }
}
