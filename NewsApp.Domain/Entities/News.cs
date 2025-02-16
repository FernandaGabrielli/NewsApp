namespace NewsApp.Domain.Entities
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Source { get; set; }
    }
}