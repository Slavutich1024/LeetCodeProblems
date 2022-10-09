using System;


namespace LongestCommonPrefix
{
    class Programm
    {
        static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";

            else if (strs.Length == 1)
                return strs[0];

            string prefix = "";
            int checkSymbol = 0;
            int j = 1;

            while (true)
            {
                if (j == strs.Length)
                {
                    prefix += strs[0][checkSymbol];
                    checkSymbol++;
                    j = 1;
                }

                while (j < strs.Length)
                {
                    if (checkSymbol == strs[0].Length ||
                        checkSymbol == strs[j].Length)
                        return prefix;

                    else if (strs[0][checkSymbol] == strs[j][checkSymbol])
                        j++;
                    else
                        return prefix;
                }
            }
        }

        static void Main(string[] args)
        {
            string[] test = { "car", "car", "carout" };
            Console.WriteLine(LongestCommonPrefix(test));
        }
    }
}
                
                    




































