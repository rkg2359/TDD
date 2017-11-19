using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWrapper
{
    public class StringWrapper
    {
        public static string GetWrapper(string input)
        {
            return input;
        }

        public static int GetColumn(int col)
        {
            return col;
        }

        public static bool GetCharCheck(string input, int col)
        {
            bool check = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[col] != ' ')
                    check = true;
            }
            return check;
        }

        public static bool GetIsBreak(string input, int col)
        {
            throw new NotImplementedException();
        }
    }
}
