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

        public static bool GetIsBreak(string input, int col)
        {
            bool output = false;
            StringBuilder sb = new StringBuilder(input);
            for(int i = 0; i < input.Length; i++)
            {
                if(i == col)
                    sb[i] = '\n';
                
            }
            if (sb[col] == '\n')
                output = true;
            
            return output;
        }


        public static string GetInsertLineBreak(string input, int col)
        {

            if(input == null)
            {
                return null;
            }

            char[] c = input.ToCharArray();
            int lastLineBreak = 0;
            bool shouldBreak = false;
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < c.Length; i++)
            {
                if(shouldBreak && c[i] == ' ')
                {
                    sb.Append('\n');
                    lastLineBreak = i;
                    shouldBreak = false;
                } else
                {
                    sb.Append(c[i]);
                    
                }
                if(i - lastLineBreak + 1 == col)
                {
                    shouldBreak = true;
                }

            }
            return sb.ToString();
        }
    }
}
