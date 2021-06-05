using System;
using System.Text;

namespace Kata.StringCalculator
{

    /// <summary>
    /// Followed the Kata rules from the below link :-
    /// https://codereview.stackexchange.com/questions/128361/tdd-kata-string-calculator#:~:text=%20TDD%20-%20Kata%20-%20String%20Calculator%20,to%20refactor%20after%20each%20passing%20test%20More%20
    /// </summary>
    public class StringCalculator
    {
        string[] delimiters = new string[] { ",", "\n" };
        public int Add(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;
            
            modifyDelimiterIfExists(str);
            str = removeUpUntilDelimiterIfCustomDelimiterExists(str);

            string[] strSplit = str.Split(delimiters, StringSplitOptions.None);
            return multipleValues(strSplit);
        }

        private string removeUpUntilDelimiterIfCustomDelimiterExists(string str)
        {
            if (str.StartsWith("//"))
                str = str.Substring(str.IndexOf("\n") + 1);

            return str;
        }
        private void modifyDelimiterIfExists(string str)
        {
            if (str.StartsWith("//"))
            {
                int startIndex = 2;
                int length = str.IndexOf("\n") - startIndex;
                delimiters = new string[] { str.Substring(startIndex, length) };
                
            }

            
        }

        private int multipleValues(string[] strSplit)
        {
            int val = 0;
            StringBuilder sb = new StringBuilder();
            foreach (string s in strSplit)
            {
                if(s.StartsWith('-'))
                {
                    sb.Append(s + ',');
                    continue;
                }
                int tmpVal = convertToInt(s);
                if (tmpVal > 1000)
                    continue;

                val += tmpVal;
            }
            if (sb.Length > 0)
                throw new ArgumentException($"Negatives not allowed - {sb}");
            return val;
        }

        private int convertToInt(string val)
        {
            try
            {
                int res = Convert.ToInt32(val);
                return res;
            }
            catch
            {
                throw new ArgumentException("Input is not valid");
            }
        }
    }
}
