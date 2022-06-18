using System;

namespace NickolasGettelHomework05
{

    class Program
    {
        static void Main(string[] args)
        {
            Fraction test = new Fraction(2, 2);
            Fraction test2 = new Fraction(2,2);

            Fraction test3 = test + test2;
            test3.Reduce();

            string testOutput = test3.ToString();
            Console.WriteLine(testOutput);
            string asdf = Console.ReadLine();
        }
        

    }
}
