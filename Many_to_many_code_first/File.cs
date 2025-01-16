namespace Many_to_many_code_first
{
    public class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }
        public string FullPath { get; set; }
        public Guid FolderId { get; set; }

        public File(string name, double size, string fullPath)
        {
            Id = Guid.NewGuid();
            Name = name;
            Size = size;
            FullPath = fullPath;
        }

        public File(string name, double size, string fullPath, Guid folderId) : this(name, size, fullPath)
        {
            FolderId = folderId;
        }
    }
}
