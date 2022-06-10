using System;

namespace NickolasGettelHomework05
{

    class Program
    {
        static void Main(string[] args) 
        { 
            Fraction test = new Fraction(2, 2, 4);
            Fraction test2 = new Fraction(1, 4, 5);

            Fraction test3 = test + test2;
            
            string testOutput = test3.ToString();
            Console.WriteLine(testOutput);

            string asdf = Console.ReadLine();

        }




    }
}
