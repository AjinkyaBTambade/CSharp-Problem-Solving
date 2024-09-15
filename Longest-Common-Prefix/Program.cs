using System;

namespace LongestCommonPrefixApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strings = { "book", "bookt", "bookx",};
            Console.WriteLine(LongestCommonPrefix(strings));
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            Array.Sort(strs);
            string first = strs[0];
            string last = strs[strs.Length - 1];

            int i = 0;
            while (i < first.Length && i < last.Length && first[i] == last[i])
            {
                i++;
            }

            return first.Substring(0, i);
        }
    }
}
