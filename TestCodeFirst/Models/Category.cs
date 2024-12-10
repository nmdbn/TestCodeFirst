using System.ComponentModel.DataAnnotations;

namespace TestCodeFirst.Models
{
    //public class Category
    //{
    //    public int CategoryId { get; set; }
    //    public string CategoryName { get; set; } = null!;
    //    public virtual ICollection<Book>? Books{ get; set; }
    //}
    public class Category
    {
        [Required(ErrorMessage = "CategoryId is required.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "CategoryName is required.")]
        [StringLength(100, ErrorMessage = "CategoryName cannot be longer than 100 characters.")]
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<Book>? Books { get; set; }
    }
}
