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
            StringBuilder sb = new StringBuilder(input);
            for (int i = 0; i < input.Length; i++)
            {
                if (i == col)
                    sb[i] = '\n';
            }
            if (sb[col] == '\n')
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
        public void emptyStringTest()
        {
            Assert.AreEqual("", StringWrapper.GetInsertLineBreak("", 5));
        }
    }
}
