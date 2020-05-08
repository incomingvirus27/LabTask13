using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuestionTwoDelegateApp
{
    class TestDelegate
    {
        
        public string Space(string str)
        {
            str = string.Concat(str.Select(x => Char.IsLower(x) || Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
            return str;
        }       
        
        public string Reverse(string str)
        {
            char[] cArray = str.ToCharArray();
            string nameReverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                nameReverse += cArray[i];
            }
            return (nameReverse);
        }
        
    }
}
