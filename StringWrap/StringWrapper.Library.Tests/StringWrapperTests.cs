using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWrapper.Library.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void returnString(
            [Values("the Quick brown fox")] string input)
        {
            string output = StringWrapper.GetWrapper(input);
            Assert.AreEqual(input, output);
        }
        [Test]
        public void checkIfColumnNumberReturns(
            [Values(10)] int col)
        {
            int outputCol = StringWrapper.GetColumn(col);
            Assert.AreEqual(col, outputCol);
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
