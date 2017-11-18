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
        public void returnString()
        {
            string input = "The Quick brown fox";
            string output = StringWrapper.GetWrapper(input);
            Assert.AreEqual(input, output);
        }
        [Test]
        public void checkIfColumnNumberReturns()
        {
            int col = 10;
            int outputCol = StringWrapper.GetColumn(col);
            Assert.AreEqual(col, outputCol);
        }

    }
}
