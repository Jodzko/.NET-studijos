namespace EF_Core_App
{
    public class Page
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Content { get; set; }


        public Page(int number, string content)
        {
            Id = Guid.NewGuid();
            Number = number;
            Content = content;
        }
    }
}
