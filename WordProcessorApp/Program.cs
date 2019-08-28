using System;
using WordProcessor;

namespace WordProcessorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            WordProcessing Words = new WordProcessing();

            string input = "";
            int shiftAmt = 0;
            string pattern = "";



            Console.WriteLine("What would you to do?");
            Console.WriteLine("Option 1: Alternating Case");
            Console.WriteLine("Option 2: Shifting Words");
            Console.WriteLine("Option 3: Most Common Letter");
            Console.WriteLine("Option 4: Amount of different Characters");
            Console.WriteLine("Option 5: Find Letter Patterns");



            int Choice = int.Parse(Console.ReadLine());

            if (Choice == 1)
            {

                Console.WriteLine("Please Enter a Word to alternate case");
                input = Console.ReadLine();

                var Result = Words.AlternateCase(input);
                Console.WriteLine(Result);
            }
            else if (Choice == 2)
            {

                Console.WriteLine("Please Enter a Word");
                input = Console.ReadLine();

                Console.WriteLine("Please enter a number to shift your word");
                shiftAmt = int.Parse(Console.ReadLine());

                var Result = Words.ShiftWord(input, shiftAmt);

                Console.WriteLine(Result);
            }
            else if (Choice == 3)
            {
                Console.WriteLine("Please Enter a Word");
                input = Console.ReadLine();

                var Result = Words.MostCommonLetter(input);

                Console.WriteLine("Most common letter: " + Result);


            }
            else if (Choice == 4)
            {
                Console.WriteLine("Please Enter a Word");
                input = Console.ReadLine();


                var Result = Words.AmtOfDifferentChars(input);

                Console.WriteLine(Result);


            }
            else if (Choice == 5)
            {
                Console.WriteLine("Please Enter a Word");
                input = Console.ReadLine();

                Console.WriteLine("Please enter a pattern from your word");
                pattern = Console.ReadLine();

                var Result = Words.findPattern(input, pattern);

                Console.WriteLine(Result);


            }
            else
            {
                Console.WriteLine("Invalid input, closing application.");
                Console.ReadLine();
            }




        }
    }
}
