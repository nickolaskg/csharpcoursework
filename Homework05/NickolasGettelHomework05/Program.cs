using System;

namespace NickolasGettelHomework05
{

    class Program
    {
        static void Main()
        {
            // Instantiate new Fraction objects
            Fraction testFraction = new Fraction(1, 2);
            Fraction testFraction2 = new Fraction(3, 5);

            // Add Fraction objects together
            Fraction testFraction3 = testFraction + testFraction2;

            // Reduce Fraction objects
            testFraction3.Reduce();

            // Output Fraction toString
            string output = testFraction3.ToString();
            Console.WriteLine(output);
        }
        

    }
}
