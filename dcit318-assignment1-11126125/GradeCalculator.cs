using System;

namespace DCIT318Assignment1
{
    public static class GradeCalculator
    {
        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=== GRADE CALCULATOR ===");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This program converts numerical grades to letter grades.");
            Console.ResetColor();

            bool validInput = false;
            double grade = 0;

            while (!validInput)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nEnter a numerical grade between 0 and 100: ");
                Console.ResetColor();
                string? input = Console.ReadLine();

                if (double.TryParse(input, out grade))
                {
                    if (grade >= 0 && grade <= 100)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: Grade must be between 0 and 100. Please try again.");
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

            string letterGrade = DetermineLetterGrade(grade);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nNumerical Grade: {grade}");
            Console.WriteLine($"Letter Grade: {letterGrade}");
            Console.ResetColor();
        }

        private static string DetermineLetterGrade(double grade)
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }
    }
}