namespace HomeWork_11.Utils.Validators.UniversityValidator
{
    internal static class UniversityValidator
    {
        public static bool CheckUniversityParams(string id, string name, string description)
        {
            bool hasError = false;

            if (!Int32.TryParse(id, out _))
                hasError = true;

            if (!NameValidator.NameValidator.CheckName(name))
                hasError = true;

            if (!NameValidator.NameValidator.CheckName(description))
                hasError = true;

            return !hasError;
        }
    }
}
