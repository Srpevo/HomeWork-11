namespace HomeWork_11.Core.Classes.University
{
    internal class University
    {
        public University(int id, string? name, string? description)
        {
            Id = id;
            Name = name;
            Description = description;
        } 

        public University() { }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
