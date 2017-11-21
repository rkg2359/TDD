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
        public static string GetWrapper(string input)
        {
            return input;
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
            bool o = false;
            StringBuilder sb = new StringBuilder(input);
            for(int i = 0; i < input.Length; i++)
            {
                if(i == col)
                {
                    sb[i] = '\n';
                }
            }
            if (sb[col] == '\n')
            {
                o = true;
            }
            Debug.WriteLine(input.Length);
            Debug.WriteLine(sb.ToString());
            return o;
        }

        public static List<string> GetList(string input, int col)
        {

            List<string> outputList = new List<string>();
            if (input == String.Empty)
                return new List<string>();
            string[] splitWords = input.Split(' ');
            foreach (string str in splitWords)
            {
                outputList.Add(str);
            }
            return outputList;
        }

        public static string GetInsertLineBreak(string input, int col)
        {
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
