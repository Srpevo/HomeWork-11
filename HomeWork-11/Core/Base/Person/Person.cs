namespace HomeWork_11.Core.Base.Person
{
    internal abstract class Person
    {
        public Person() { }

        public Person(int id, string? name, string? surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        } 

        int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
