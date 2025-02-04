namespace BookStoreManager.Models
{
    public class Book
    {
        public required int Id { get; set; }

        public required BookFormat BookFormat { get; set; }

        public required string ISBN { get; set; }
        public required string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime DatePublished { get; set; } = DateTime.Now;
        public int Cost { get; set; } = 0;
        public int NoOfCopies { get; set; } = 1;
    }
}
