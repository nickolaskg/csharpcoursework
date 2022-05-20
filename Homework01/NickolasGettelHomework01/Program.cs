using System;
using System.Collections.Generic;
using static System.Console;

namespace NickolasGettelHomework01
{
    class Program
    {
        static void Main(string[] args)
        {
            int dollarAmount = 0;
            bool isSessionActive = true;
            int[] billArray = { 20, 10, 5, 1 };

            // Indefinitely loop program until user chooses to stop
            while(isSessionActive)
            {
                IDictionary<int, int> denominations = new Dictionary<int, int>();
                denominations.Add(20, 0);
                denominations.Add(10, 0);
                denominations.Add(5, 0);
                denominations.Add(1, 0);

                Write("Enter a dollar amount for change or type 'STOP' to end the program: ");
                string userInput = ReadLine();

                if(userInput.ToLower() == "stop")
                {
                    isSessionActive = false;
                    continue;
                } 

                // Validate userInput is a positive number; Skip to next loop if invalid
                if(!int.TryParse(userInput, out dollarAmount) || dollarAmount <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLine("Please enter a positive number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                // For each bill in billArray continuously reduce dollarAmount by bill value, and
                // increment demnomination value by 1 until dollarAmount value is lower than current bill 
                foreach (var bill in billArray)
                {
                    while (dollarAmount >= bill)
                    {
                        denominations[bill]++;
                        dollarAmount -= bill;
                    }
                }

                // Print results
                WriteLine("\n-------------------------------");
                WriteLine("Amount of bills to make change:");
                Console.ForegroundColor = ConsoleColor.Green;

                foreach (KeyValuePair<int, int> dollarValue in denominations)
                {
                    string billAmount = dollarValue.Key.ToString("C");
                    WriteLine($"{billAmount}: ({dollarValue.Value})");
                }

                Console.ForegroundColor = ConsoleColor.White;
                WriteLine("-------------------------------\n");
            }

        }

    }
}
