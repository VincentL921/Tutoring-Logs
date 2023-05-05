using System;
namespace PasswordChecker
{
    public class Tools
    {
        public Tools()
        {

        }

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }
    }
}
