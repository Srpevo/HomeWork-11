using System.Text.RegularExpressions;

namespace HomeWork_11.Utils.Validators.EmailValidator
{
    internal static class EmailValidator
    {

        public static bool CheckEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            var Regx = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"); // ;)

            if (!Regx.IsMatch(email))
                return false;


            return true;
        }
    }
}