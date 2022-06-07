using System;
using static System.Console;

namespace NickolasGettelHomework04
{
    class Program
    {
         private static int[] integerArray = new int[10];
        static void Main(string[] args)
        {
            // Declare variables
            int min, max, avg, sum;

            // Call method to prompt user for integers to fill an array interactively /w error rejection message/prompt
            PromptForIntegers();

            // Call a method with out parameters to provide the low, high, avg, and sum of the array values
            ComputeIntegers(out min, out max, out avg, out sum);

            // Display the statistics within the main()
            WriteLine("\n*******************************************");
            WriteLine($" Lowest Value: {min} - Highest Value: {max}");
            WriteLine($"Average Value: {avg} - Sum of Values: {sum}");
            WriteLine("*******************************************");
        }

        public static void PromptForIntegers()
        {
            // Declare temp variable
            string userInput;
            int parsedInt = 0;
            int numberOfInputs = 0;
            bool isSessionActive = true;

            // While Loop based on isSessionActive bool
            while (isSessionActive || numberOfInputs > 11)
            {
                // If last element in the array has a value - end loop
                if(numberOfInputs == 10)
                {
                    isSessionActive = false;
                    continue;
                }

                // Prompt user for integer
                Write($"Enter ({10 - numberOfInputs}) more digits: ");
                // Assign value to temp variable
                userInput = ReadLine();

                // Check for sentinel value to stop the program
                if(userInput.ToLower() == "stop")
                {
                    isSessionActive = false;
                    continue;
                }

                // True if able to parse to Int
                if (int.TryParse(userInput, out parsedInt))
                {
                    // -> Add validated integer into array
                    integerArray[numberOfInputs] = parsedInt;
                    numberOfInputs++;
                } else
                {
                    // -> Else Reprompt user for valid integer
                    WriteLine("Invalid entry. Please enter only integers.");
                }
            }
        }

        public static void ComputeIntegers(out int min, out int max, out int avg, out int sum)
        {
            int tempMin = 0, tempMax = 0 , tempAvg = 0, tempSum = 0;

            // Determine and delcare min
            foreach (int num in integerArray)
            {
                if (tempMin == 0)
                {
                    tempMin = num;
                }
                else
                {
                    if (num < tempMin)
                    {
                        tempMin = num;
                    }
                }
            }
            // Determine and delcare max
            foreach (int num in integerArray)
            {
                if (tempMax == 0)
                {
                    tempMax = num;
                }
                else
                {
                    if (num > tempMax)
                    {
                        tempMax = num;
                    }
                }
            }

            // Determine and delcare avg
            foreach (int num in integerArray)
            {
                tempAvg = tempAvg + num;
            }
            tempAvg = tempAvg / integerArray.Length;
            // Determine and delcare sum
            foreach (int num in integerArray)
            {
                tempSum = tempSum + num;
            }

            min = tempMin;
            max = tempMax;
            avg = tempAvg;
            sum = tempSum;
        }

    }
}
