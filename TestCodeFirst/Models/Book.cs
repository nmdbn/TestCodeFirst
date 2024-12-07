namespace TestCodeFirst.Models
{
    public class Book
    {
        public required string Id { get; set; }
        public required string Title { get; set; }
        public string? Author { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
