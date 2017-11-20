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
        [TestCase("The Quick Brown fox", 14)]
        public void returnInputs(string input, int col)
        {
            int column = col;
            string output = StringWrapper.GetWrapper(input);
            Assert.AreEqual(input, output);
        }

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
        [TestCase("The Quick Brown fox jumped over the bridge and laughed at others", 7)]
        public void checkLines(string input, int col)
        {
            List<string> lines = new List<string>();
            string[] words = input.Split(' ');
            int wordCounter = 0;
            foreach(string word in words)
            {
                lines[wordCounter] = word;
            }

            List<string> output = StringWrapper.GetList(input, col);
            bool b = lines.SequenceEqual(output);
            Assert.IsTrue(b);
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
    }
}
