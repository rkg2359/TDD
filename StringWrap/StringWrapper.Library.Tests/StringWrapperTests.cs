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
        [TestCase("The Quick Brown fox",14)]
        public void returnInputs(string input, int col)
        {
            int column = col;
            string output = StringWrapper.GetWrapper(input);
            Assert.AreEqual(input, output);
        }
        
        [Test]
        [TestCase("The Quick Brown fox", 14)]
        public void checkBreakCharacter(string input, int col)
        {
            bool isBreak = false;
            
            for(int i = 0; i < input.Length; i++)
            {
                if (input[col].ToString() == Environment.NewLine)
                    isBreak = true;
            }
            bool output = StringWrapper.GetIsBreak(input, col);
            Assert.AreEqual(isBreak, output);
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
