using CSharpCore.Lessons.Classes.Partial;
using CSharpCore.Lessons.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore.Lessons.Extensions
{
    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string ExFullName(this User value)
                => $"{value.Firstname} {value.Lastname}";
    }
}
