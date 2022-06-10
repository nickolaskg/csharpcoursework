using System;
using System.Collections.Generic;
using System.Text;

namespace NickolasGettelHomework05
{
    class Fraction
    {

        public int WholeNumber { get; set; }
        public int Numerator { get; set; }
        public int Denominator
        {
            get { return Denominator; }
            set
            {
                if (value > 0)
                {
                    Denominator = value;
                }
                else
                {
                    Denominator = 1;
                }
            }
        }

        Fraction(int wholeNumber, int numerator, int denominator)
        {
            WholeNumber = wholeNumber;
            Numerator = numerator;
            Denominator = denominator;
        }

        Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        Fraction()
        {
            WholeNumber = 0;
            Denominator = 1;
        }
    }
}
