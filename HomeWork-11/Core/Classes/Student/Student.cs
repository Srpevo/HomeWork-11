using HomeWork_11.Core.Base.Person;
using HomeWork_11.Core.Interfaces.Istudent;

namespace HomeWork_11.Core.Classes.Student
{
    internal class Student : Person, Istudent
    {

        public Student(int id, string? name, string? surname, string? email, string? universityName) : base(id, name, surname)
        {
            Email = email;
            UniversityName = universityName;
        }

        public Student() { }

        public string? Email { get; set; }
        public string? UniversityName { get; set; } 
    }
}
