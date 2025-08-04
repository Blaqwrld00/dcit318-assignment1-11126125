using System;

namespace DCIT318Assignment1
{
    public static class TriangleTypeIdentifier
    {
        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n=== TRIANGLE TYPE IDENTIFIER ===");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This program determines the type of triangle based on three side lengths.");
            Console.ResetColor();

            double side1 = GetValidSide("first");
            double side2 = GetValidSide("second");
            double side3 = GetValidSide("third");

            if (IsValidTriangle(side1, side2, side3))
            {
                string triangleType = DetermineTriangleType(side1, side2, side3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nSide 1: {side1}");
                Console.WriteLine($"Side 2: {side2}");
                Console.WriteLine($"Side 3: {side3}");
                Console.WriteLine($"Triangle Type: {triangleType}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nError: The sides {side1}, {side2}, and {side3} cannot form a valid triangle.");
                Console.WriteLine("The sum of any two sides must be greater than the third side.");
                Console.ResetColor();
            }
        }

        private static double GetValidSide(string sideName)
        {
            bool validInput = false;
            double side = 0;

            while (!validInput)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Enter the {sideName} side length: ");
                Console.ResetColor();
                string? input = Console.ReadLine();

                if (double.TryParse(input, out side))
                {
                    if (side > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: Side length must be greater than 0. Please try again.");
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

            return side;
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            // Triangle inequality theorem: sum of any two sides must be greater than the third side
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        private static string DetermineTriangleType(double a, double b, double c)
        {
            // Check if all sides are equal (Equilateral)
            if (Math.Abs(a - b) < 0.001 && Math.Abs(b - c) < 0.001)
            {
                return "Equilateral";
            }
            // Check if two sides are equal (Isosceles)
            else if (Math.Abs(a - b) < 0.001 || Math.Abs(a - c) < 0.001 || Math.Abs(b - c) < 0.001)
            {
                return "Isosceles";
            }
            // No sides are equal (Scalene)
            else
            {
                return "Scalene";
            }
        }
    }
}