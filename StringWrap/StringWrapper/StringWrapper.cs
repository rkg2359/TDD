using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringWrapper
{
    public class StringWrapper
    {

        public static string GetInsertLineBreak(string input, int col)
        {

            if (input == null)
                return null;

            char[] chars = input.ToCharArray();
            int lastLineBreak = 0;
            bool shouldBreak = false;
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < chars.Length; i++)
            {
                if(shouldBreak && chars[i] == ' ')
                {
                    sb.Append('\n');
                    lastLineBreak = i;
                    shouldBreak = false;
                } else
                    sb.Append(chars[i]);
                if(i - lastLineBreak + 1 == col)
                    shouldBreak = true;

            }
            return sb.ToString();
        }
    }
}
