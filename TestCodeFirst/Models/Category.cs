﻿namespace TestCodeFirst.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public virtual ICollection<Book>? Books{ get; set; }
    }
}
