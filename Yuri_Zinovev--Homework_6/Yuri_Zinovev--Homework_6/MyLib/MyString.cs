using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public static class MyString
    {
        public static string JoinList(List<string> list)
        {
            return String.Join(" ", list.ToArray());
        }

        public static string FilterByWordLength(string text, int maxLength)
        {
            List<string> allWords = SplitText(text);
            return JoinList(allWords.Where(x => x.Length <= maxLength).ToList());
        }

        public static string FilterByLastSymbol(string text, char symbol)
        {
            List<string> allWords = SplitText(text);
            return JoinList(allWords.Where(x => x.Last() != symbol).ToList());
        }

        public static string GetMaxLengthWords(string text)
        {
            List<string> allWords = SplitText(text);
            int maxLength = int.MinValue;
            foreach (string s in allWords)
                if (maxLength < s.Length)
                {
                    maxLength = s.Length;
                }

            return JoinList(allWords.Where(x => x.Length == maxLength).ToList());
        }

        public static bool IsReshuffle(string str1, string str2, bool ignoreSizeCase)
        {
            if (ignoreSizeCase)
            {
                str1 = str1.ToLower();
                str2 = str2.ToLower();
            }

            FrequencyArray<char> fa1 = new FrequencyArray<char>(str1.ToArray());
            FrequencyArray<char> fa2 = new FrequencyArray<char>(str2.ToArray());

            return fa1.Equals(fa2);
        }

        public static bool IsReshuffle(string str1, string str2)
        {
            return IsReshuffle(str1, str2, false);
        }
        
        static List<string> SplitText(string text)
        {
            var splitted = text.Split(' ').ToList();
            return splitted.Where(x => x != "").ToList();
        }
    }
}
