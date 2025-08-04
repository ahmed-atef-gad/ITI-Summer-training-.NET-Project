using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Project.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [MinLength(3, ErrorMessage = "Name Min Length Is 3")]
        [MaxLength(20, ErrorMessage = "Name Max Length Is 20")]
        [DisplayName("Product Title")]
        public required string Title { get; set; }
        [Range(20, 30000, ErrorMessage = "Price Must Be Between 20 and 30000")]
        public decimal Price { get; set; }
        [MinLength(3, ErrorMessage = "Description Min Length Is 3")]
        [MaxLength(250, ErrorMessage = "Description Max Length Is 250")]
        public required string Description { get; set; }
        [DisplayName("Product Quantity")]
        [Range(1, 100, ErrorMessage = "Quantity Must Be Between 1 and 100")]
        public int Quantity { get; set; }
        [DisplayName("Product Image")]
        public string? ImagePath { get; set; }
        [ForeignKey("Category")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
