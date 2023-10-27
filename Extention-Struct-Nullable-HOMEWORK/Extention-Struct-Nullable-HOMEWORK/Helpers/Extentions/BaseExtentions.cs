using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extention_Struct_Nullable_HOMEWORK.Helpers.Extentions
{
    public static class BaseExtentions
    {


        public static string GetFullName(this string Name, string Surname)
        {
            Person person = new Person();

            Name = person.Name;
            Surname = person.Surname;

            return Name + " " + Surname;
        }


        public static bool CheckEmail(this string eamil)
        {
            if (string.IsNullOrEmpty(eamil))

            {
                return false;
            }

            return true;
        }


        public static int ProductOfNums(this int[] numbers)
        {
            int product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            return product;
        }


        public static bool EmailRegisterChech(this string email)
        {

        }
    }
}
