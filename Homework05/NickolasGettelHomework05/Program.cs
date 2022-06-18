using System;

namespace NickolasGettelHomework05
{
    // Author: Nickolas Gettel
    // Date: 6/17/2022
    // Purpose: This console app instantiates two Fraction objects.
    // Those objects are then added together using the overloaded operator+ method
    // and a new Fraction object is returned with the summed fraction.
    // Once the objects are added together, the Reduce method is then
    // called on the new Fraction object, reducing the fraction
    // to it's simplest form. Finally the .toString() method
    // is called and assigned to the variable output, and then printed
    // to the console.

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
