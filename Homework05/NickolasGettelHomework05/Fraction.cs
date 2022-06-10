using System;
using System.Collections.Generic;
using System.Text;

namespace NickolasGettelHomework05
{
    class Fraction
    {
        int wholeNumber;
        int numerator;
        int denominator;

        public int WholeNumber { get; set; }
        public int Numerator { get; set; }
        public int Denominator
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

        public static int Reduce(int wholeNumber, int numerator, int denominator)
        {
            // Place holder for actual code.
            return 0;
        }

        public static Fraction operator +(Fraction one, Fraction two)
        {
            int num, den, wholeNum = 0, numOne, numTwo, denOne = one.Denominator, denTwo = two.Denominator;

            // Eliminate whole number (1) by adding into fraction for both fractions
            if (one.WholeNumber > 0)
            {
                numOne = one.WholeNumber * one.Denominator + one.Numerator;
            }
            else
            {
                numOne = one.Numerator;
            }
            // Eliminate whole number (2) by adding into fraction
            if (two.WholeNumber > 0)
            {
                numTwo = two.WholeNumber * two.Denominator + two.Numerator;
            }
            else
            {
                numTwo = two.Numerator;
            }

            num = numOne * denTwo + numTwo * denOne;
            den = denOne * denTwo;

            // Check and convert improper fraction to whole number / fraction

            if(num > den)
            {
                wholeNum = num / den;
                num = num % den;
            }

            if(wholeNum > 0)
            {
                return new Fraction(wholeNum, num, den);
            }
            else
            {
                return new Fraction(num, den);
            }
        }

        public override string ToString()
        {
           return WholeNumber > 0 ? $"{WholeNumber} {Numerator} / {Denominator}" : $"{Numerator} / {Denominator}";
        }

    }
}
