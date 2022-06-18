using System;
using System.Collections.Generic;
using System.Text;

namespace NickolasGettelHomework05
{
    class Fraction
    {
        //int wholeNumber;
        //int numerator;
        int denominator;

        private int WholeNumber { get; set; }
        private int Numerator { get; set; }
        private int Denominator
        {
            get { return denominator; }
            set
            {
                if (value > 0)
                {
                    denominator = value;
                }
                else
                {
                    denominator = 1;
                }
            }
        }

        // Overloaded constructors
        public Fraction(int wholeNumber, int numerator, int denominator)
        {
            WholeNumber = wholeNumber;
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction()
        {
            WholeNumber = 0;
            Denominator = 1;
        }

        public void Reduce()
        {
            // Find lowest number between num & denom
            int gcd = Math.Min(Numerator, Denominator);

            // If lowest num is 0 return - cannot divide by zero
            if (gcd == 0) return;

            // Reduce gcd until a common denom is found or until it reaches 1;
            while((Numerator % gcd != 0) || (Denominator % gcd != 0))
            {
                gcd--;
            }

            // Divide num and denom by gcd
            Numerator /= gcd;
            Denominator /= gcd;             
        }

        // Overloaded operator+
        public static Fraction operator +(Fraction one, Fraction two)
        {
            int num, den, wholeNum = 0, numOne, numTwo, denOne = one.Denominator, denTwo = two.Denominator;

            // Eliminate whole number(1) by adding into fraction
            if (one.WholeNumber > 0)
            {
                numOne = one.WholeNumber * one.Denominator + one.Numerator;
            }
            else
            {
                numOne = one.Numerator;
            }
            // Eliminate whole number(2) by adding into fraction
            if (two.WholeNumber > 0)
            {
                numTwo = two.WholeNumber * two.Denominator + two.Numerator;
            }
            else
            {
                numTwo = two.Numerator;
            }

            // Check for same or different denominator
            if(denOne != denTwo)
            {
                num = numOne * denTwo + numTwo * denOne;
                den = denOne * denTwo;
            } else
            {
                num = numOne + numTwo;
                den = denOne;
            }

            // Check and convert improper fraction to whole number / fraction
            if (num > den)
            {
                wholeNum = num / den;
                num = num % den;
            }

            // If numerator and denominator are the same, convert to whole number
            if (num == den)
            {
                wholeNum = 1;
                num = 0;
                den = 0;
            }

            // Return fraction with or without whole number
            if (wholeNum > 0)
            {
                return new Fraction(wholeNum, num, den);
            }
            else
            {
                return new Fraction(num, den);
            }
        }


        // NOTE: Need to fix ToString output based on whole number
        public override string ToString()
        {
            if(this.WholeNumber > 0 && this.Numerator == 0)
            {
                return $"{WholeNumber}";
            }
            
           return WholeNumber > 0 ? $"{WholeNumber} {Numerator} / {Denominator}" : $"{Numerator} / {Denominator}";
        }

    }
}
