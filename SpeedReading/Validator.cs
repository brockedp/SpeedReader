using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedReading

{
    public class Validator
    {
        public static int GetInt(string prompt)
        {
            string input = GetUserInput(prompt);
            bool isValid = int.TryParse(input, out int result);
            if (isValid)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Please try again");
                return GetInt(prompt);
            }
        }

        public static int GetIntWithinRange(string prompt, int min, int max)
        {
            int result = GetInt(prompt);
            if (result >= min && result <= max)
            {
                return result;
            }
            else
            {
                return GetInt($"Please enter a number between {min} and {max}");
            }
        }
        public static double GetDouble(string prompt)
        {
            bool isValid = double.TryParse(prompt, out double result);
            if (isValid)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Please try again");
                return GetDouble(Console.ReadLine());
            }
        }
        public static double GetDoubleWithinRange(string prompt, double min, double max)
        {
            string input = GetUserInput(prompt);
            double result = GetDouble(input);
            if (result >= min && result <= max)
            {
                return result;
            }
            else
            {
                return GetDouble($"Please enter a number between {min} and {max}");
            }
        }
        public static string GetRequiredString(string message)
        {
            string IsString = " ";
            bool isValid = string.IsNullOrWhiteSpace(IsString);
            while (isValid)
            {
                Console.WriteLine(message);
                IsString = Console.ReadLine();
                isValid = string.IsNullOrWhiteSpace(IsString);
            }

            return IsString;
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();

        }
    }
}
