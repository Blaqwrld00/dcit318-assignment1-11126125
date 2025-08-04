using System;

namespace DCIT318Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== DCIT 318: PROGRAMMING II ASSIGNMENT 1 ===");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Multi-Calculator Console Application!");
            Console.ResetColor();

            bool continueRunning = true;

            while (continueRunning)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPlease select an option:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nEnter your choice (1-4): ");
                Console.ResetColor();

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GradeCalculator.Run();
                        break;
                    case "2":
                        TicketPriceCalculator.Run();
                        break;
                    case "3":
                        TriangleTypeIdentifier.Run();
                        break;
                    case "4":
                        continueRunning = false;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Thank you for using the Multi-Calculator Console Application!");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        Console.ResetColor();
                        break;
                }

                if (continueRunning)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}