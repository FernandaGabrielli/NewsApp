namespace NewsApp.Application.DTOs
{
    public class NewsDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Source { get; set; }
    }
}