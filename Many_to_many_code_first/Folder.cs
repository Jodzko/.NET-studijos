namespace Many_to_many_code_first
{
    public class Folder
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Folder(string name)
        {
            Id = Id = Guid.NewGuid();
            Name = name;
        }
    }
}
