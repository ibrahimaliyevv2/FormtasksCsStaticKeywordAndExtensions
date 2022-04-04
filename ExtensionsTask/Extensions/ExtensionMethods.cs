using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions
{
    public static class ExtensionMethods
    {
        public static bool IsPrime(this int num)
        {
            
                if (num == 0 || num == 1)
                {
                    return false;
                }
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
         return true;
        }

        public static bool IsPowOfTwo(this int num)
        {
            for (int i = 1; i <= num; i*=2)
            {
                if (num == i)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CustomContains(this string str, string complete)
        {
            string[] strArr = complete.Split(" ");
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i] == str)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CustomContains(this char ch, string complete)
        {
            for (int i = 0; i < complete.Length; i++)
            {
                if (complete[i] == ch)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
