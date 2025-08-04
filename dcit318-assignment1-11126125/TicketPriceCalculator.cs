using System;

namespace DCIT318Assignment1
{
    public static class TicketPriceCalculator
    {
        private const double REGULAR_PRICE = 10.0;
        private const double DISCOUNTED_PRICE = 7.0;
        private const int SENIOR_AGE = 65;
        private const int CHILD_AGE = 12;

        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n=== TICKET PRICE CALCULATOR ===");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This program calculates movie ticket prices based on age.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Regular price: GHC{REGULAR_PRICE}");
            Console.WriteLine($"Discounted price (seniors 65+ and children 12 and below): GHC{DISCOUNTED_PRICE}");
            Console.ResetColor();

            bool validInput = false;
            int age = 0;

            while (!validInput)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nEnter your age: ");
                Console.ResetColor();
                string? input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    if (age >= 0 && age <= 120)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: Age must be between 0 and 120. Please try again.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Please enter a valid number. Please try again.");
                    Console.ResetColor();
                }
            }

                        double ticketPrice = CalculateTicketPrice(age);
            string customerType = DetermineCustomerType(age);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nAge: {age}");
            Console.WriteLine($"Customer Type: {customerType}");
            Console.WriteLine($"Ticket Price: GHC{ticketPrice:F2}");
            Console.ResetColor();
        }

        private static double CalculateTicketPrice(int age)
        {
            if (age >= SENIOR_AGE || age <= CHILD_AGE)
            {
                return DISCOUNTED_PRICE;
            }
            else
            {
                return REGULAR_PRICE;
            }
        }

        private static string DetermineCustomerType(int age)
        {
            if (age >= SENIOR_AGE)
                return "Senior Citizen";
            else if (age <= CHILD_AGE)
                return "Child";
            else
                return "Adult";
        }
    }
}