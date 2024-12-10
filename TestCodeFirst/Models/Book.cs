using System.ComponentModel.DataAnnotations;

namespace TestCodeFirst.Models
{
    //public class Book
    //{
    //    public required string Id { get; set; }
    //    public required string Title { get; set; }
    //    public string? Author { get; set; }
    //    public decimal Price { get; set; }
    //    public string? Description { get; set; }
    //    public string? Image { get; set; }
    //    public int CategoryId { get; set; }
    //    public virtual Category? Category { get; set; }
    //}

    public class Book
    {
        [Required(ErrorMessage = "Id is required.")]
        [StringLength(50, ErrorMessage = "Id cannot be longer than 50 characters.")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        [StringLength(100, ErrorMessage = "Author name cannot be longer than 100 characters.")]
        public string? Author { get; set; }

        [Range(0.01, 100000000.00, ErrorMessage = "Price must be between 0.01 and 100,000,000.")]
        public decimal Price { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string? Description { get; set; }

        public string? Image { get; set; }

        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}
