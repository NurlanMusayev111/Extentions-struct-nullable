using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extentions_Struct_Nullable.Helpers.Extentions
{
    public static class BaseExtentions
    {
        public static int ShowNums(this int num1,int num2)
        {
            return num1 * num2;
        }

        public static string ShowText(this string text1,string text2,int text3)
        {
            return text1 + " " + text2 + " " + text3;
        }

        public static bool CheckEmail(this string email,string pattern)
        {
            var res = Regex.IsMatch(email,pattern);
            return res;
        }

        public static int FinfFactorial(this int num)
        {
            int factorial = 1;

            for(int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }


        public static bool CheckEmailAndPassword(this string text,string pattern)
        {
            var result = Regex.IsMatch(text,pattern);
            return result;
        }

        public static double PowOfNums(this int num,int pow)
        {
            return Math.Pow(num, pow);
        }

        public static bool IsConvertStringToNumber(this string str)
        {
            return int.TryParse(str,out int result);
        }
    }
}
