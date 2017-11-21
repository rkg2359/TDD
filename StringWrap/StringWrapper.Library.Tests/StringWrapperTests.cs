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
        [TestCase("The quick brown fox jumped over the lazy dog", 15)]
        public void checkLongSentenceBreaks(string input, int col)
        {
            string output = "The quick brown\nfox jumped over\nthe lazy dog";
            Assert.AreEqual(output, StringWrapper.GetInsertLineBreak(input, col));
        }

        [Test]
        [TestCase("abc def", 5)]
        public void checkShortSentenceBreaks(string input, int col)
        {
            string output = "abc def";
            Assert.AreEqual(output, StringWrapper.GetInsertLineBreak(input, col));
        }

        [Test]
        public void emptyStringTest()
        {
            Assert.AreEqual("", StringWrapper.GetInsertLineBreak("", 5));
        }
    }
}
