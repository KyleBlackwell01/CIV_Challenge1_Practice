using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordProcessor
{
    public class WordProcessing
    {

        public string AlternateCase(string input)
        {

            string result = new String(input.ToCharArray().Select((character, index) => (index % 2) == 0 ? Char.ToUpper(character) : character).ToArray());

            return result;

            //throw new NotImplementedException();
        }

        public string ShiftWord(string input, int shiftAmt)
        {

            var shiftedText = string.Empty;

            foreach (var character in input)
            {
                if (!char.IsLetter(character))
                {
                    shiftedText += character;
                }
                else
                {
                    var newChar = (char) (character - shiftAmt);

                    if (newChar < (char.IsLower(character) ? 'a' : 'A')) newChar += (char) 26;

                    shiftedText += newChar;
                }
            }

            return shiftedText;


            //throw new NotImplementedException();
        }

        public char MostCommonLetter(string input)
        {
            int[] charCount = new int[256];
            int length = input.Length;
            for (int i = 0; i < length; i++)
            {
                charCount[input[i]]++;
            }
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < length; i++)
            {
                if (maxCount < charCount[input[i]])
                {
                    maxCount = charCount[input[i]];
                    character = input[i];
                }
            }

            var result = character;

            return result;

            //throw new NotImplementedException();
        }

        public int AmtOfDifferentChars(string input)
        {

            int count = input.Distinct().Count();

            return count;


            //throw new NotImplementedException();
        }

        public int findPattern(string input, string pattern)
        {

            Match m = Regex.Match(input, pattern);
            int fIndex = 0;

            while (m.Success)
            {
                fIndex = m.Index;
                m = m.NextMatch();
                
            }
            if (fIndex > 0)
            {
                return fIndex;
            }
            else
            {
                return -1;
            }
 


            //throw new NotImplementedException();
        }

        // Extra
        //public string findLongestPattern(string input1, string input2)
        //{
        //    throw new NotImplementedException();
        //}

    }

    public class InvalidWordException : Exception
    {
        public InvalidWordException(string message) : base(message)
        {

        }
    }

    public class InvalidStringException : Exception
    {
        public InvalidStringException(string message) : base(message)
        {

        }
    }


}
