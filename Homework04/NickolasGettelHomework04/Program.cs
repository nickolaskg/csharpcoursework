using System;
using static System.Console;

namespace NickolasGettelHomework04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int min, max, avg, sum;
            int[] integerArray = new int[10];

            // Call method to prompt user for integers to fill an array interactively /w error rejection message/prompt
            PromptForIntegers();

            // Call a method with out parameters to provide the low, high, avg, and sum of the array values
            ComputeIntegers(out min, out max, out avg, out sum);

            // Display the statistics within the main()
            WriteLine($"Lowest Value: {min} - Highest Value: {max}");
            WriteLine($"Average Value: {avg} - Sum of Values: {sum}");
        }

        public static void PromptForIntegers()
        {
            // Declare temp variable
            bool isSessionActive = true;

            // While Loop based on isSessionActive bool
            // Prompt user for integer
            // Assign value to temp variable
            // Check for sentinel value to stop the program
            // Yes: Stop program - No: Continue - assign bool value to isSessionActive in main()
            // Try parsing value integer
            // If integer is within specification
            // Add validated integer into array
            // Else Reprompt user for valid integer
        }

        public static void ComputeIntegers(out int min, out int max, out int avg, out int sum)
        {
            // Determine and delcare min
            min = 0;
            // Determine and delcare max
            max = 0;
            // Determine and delcare avg
            avg = 0;
            // Determine and delcare sum
            sum = 0;
        }

    }
}
