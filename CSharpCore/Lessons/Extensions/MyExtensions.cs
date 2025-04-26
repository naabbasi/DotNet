using CSharpCore.Lessons.Classes.Partial;

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