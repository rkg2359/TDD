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
        public string input
        {
            set
            {
                input = value;
            }
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
            return null;
        }
    }
}
