using System;
using System.Collections.Generic;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            HashSet<Char> letters = new HashSet<char>();
            string text = input.ToUpper();

            for(int i = 0; i < text.Length; i++)
            {
                if('A' <= text[i] && text[i] <= 'Z')
                {
                    letters.Add(text[i]);
                }
            }
            if(letters.Count != 26)
            {
                return false;
            }
            return true;
        }
    }
}
