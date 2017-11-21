using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringWrapper.Library.Tests
{
    [TestFixture]
    public class Class1
    {

        [Test]
        [TestCase("The Quick Brown fox", 2)]
        [TestCase("The Quick Brown fox", 9)]
        [TestCase("The Quick Brown fox", 7)]
        public void checkBreakCharacter(string input, int col)
        {
            bool isBreak = false;
            StringBuilder s = new StringBuilder(input);
            for (int i = 0; i < input.Length; i++)
            {
                if (i == col)
                    s[i] = '\n';
            }
            if (s[col] == '\n')
                isBreak = true;
            bool output = StringWrapper.GetIsBreak(input, col);
            Assert.AreEqual(isBreak, output);
        }

        [Test]
        [TestCase("The quick brown fox jumped over the lazy dog", 15)]
        public void checkLineBreaks(string input, int col)
        {
            string output = StringWrapper.GetInsertLineBreak(input, col);
            Assert.AreEqual("The quick brown\nfox jumped over\nthe lazy dog",output);
        }

        [Test]
        public void charCheck(//check if char is null or valid char
            [Values(15)] int col)
        {
            string input = "brown fox jumped over the wall";
            bool isChar = false;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[col] != ' ')
                    isChar = true;
            }
            bool output = StringWrapper.GetCharCheck(input, col);
            Assert.AreEqual(true, isChar);

        }

        [Test]
        public void emptyStringTest()
        {
            Assert.AreEqual(new List<string>(), StringWrapper.GetList("", 5));
            //Assert.Equals(new List<string>(), StringWrapper.GetList("", 5));
        }



    }
}
