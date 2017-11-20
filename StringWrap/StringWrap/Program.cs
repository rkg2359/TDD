using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringWrapper.Library;

namespace StringWrap
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = "hello my name is Zack!";
            Console.WriteLine(StringWrapper.StringWrapper.GetIsBreak(inp, 5));
        }
    }
}
