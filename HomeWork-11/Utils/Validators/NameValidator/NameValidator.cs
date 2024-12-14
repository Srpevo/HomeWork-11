namespace HomeWork_11.Utils.Validators.NameValidator
{
    internal static class NameValidator
    {
        public static bool CheckName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            else if (name.Length < 3)
                return false;

            else return true;
        }
    }
}