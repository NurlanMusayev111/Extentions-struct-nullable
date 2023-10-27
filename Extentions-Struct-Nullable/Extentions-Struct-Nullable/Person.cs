using Extentions_Struct_Nullable.Helpers.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentions_Struct_Nullable
{
    internal class Person
    {
        public string Email { get; set; }
        public int Id { get; set; }

        public Person(string email)
        {
            Email = email;
            Console.WriteLine(Email.CheckEmail(@"\W"));
        }
    }
}
