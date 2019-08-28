using WordProcessor;
using NUnit.Framework;
using System;

namespace WordProcessorTests
{
    public class WordProcessorTests
    {
        WordProcessing Words;

        [SetUp]
        public void Setup()
        {
            Words = new WordProcessing();
        }

        [Test]
        [TestCase("Test", "TeSt")]
        [TestCase("test", "TeSt")]
        public void AlternateCaseTest(string input, string ans)
        {
            var result = Words.AlternateCase(input);

            Assert.AreEqual(ans, result);
        }

        [Test]
        [TestCase("abc", 2, "yza")]
        [TestCase("abc", -2, "cde")]
        public void ShiftWordTest(string input, int shiftAmt, string ans)
        {
            var result = Words.ShiftWord(input, shiftAmt);

            Assert.AreEqual(ans, result);
        }

        [Test]
        [TestCase ("test", "t")]
        [TestCase ("TTTtttTTT", "T")]
        [TestCase ("AAAAAttttt", "t")]
        public void MostCommonLetterTest(string input, char ans)
        {
            var result = Words.MostCommonLetter(input);

            Assert.AreEqual(ans, result);
        }

        [Test]
        [TestCase ("TEST",3)]
        [TestCase ("Test",4)]
        [TestCase ("testing",6)]
        public void AmtOfDifferentCharsTest(string input, int ans)
        {



            var result = Words.AmtOfDifferentChars(input);

            //Assert.AreEqual(ans, result);

            Assert.That(result, Is.EqualTo(ans));


        }

        [Test]
        [TestCase ("abcab", "ab", 3)]
        [TestCase ("abcabcab", "ab", 6)]
        public void findPatternTest (string input, string pattern, int ans)
        {
            var result = Words.findPattern(input, pattern);

            Assert.AreEqual(ans, result);
        }


        //[Test]
        //public void WordProcessor_WithDefaultValue_ThrowsException()
        //{
        //    Assert.Throws<InvalidStringException>(() => new Customer(default(int)));
        //}


    }
}
