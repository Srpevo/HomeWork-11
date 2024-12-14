using HomeWork_11.Core.Classes.University;

namespace HomeWork_11.Utils.Validators.StudentValidator
{
    internal static class StudentValidator
    {
        private static bool CheckUniversities(string studentUniversity, List<University> universities)
        {
            foreach (var univer in universities)
                if (univer.Name == studentUniversity)
                    return true;

            return false;
        }

        public static bool CheckStudentParams(string id, string name, string surname, string email, string studentUniversity, List<University> universities)
        {
            bool hasError = false;

            if (!Int32.TryParse(id, out _))
                hasError = true;

            if (!NameValidator.NameValidator.CheckName(name))
                hasError = true;

            if (!NameValidator.NameValidator.CheckName(surname))
                hasError = true;

            if (!EmailValidator.EmailValidator.CheckEmail(email))
                hasError = true;

            if (!CheckUniversities(studentUniversity, universities))
                hasError = true;

            return !hasError;
        }
    }
}
