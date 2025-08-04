using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [MinLength(3, ErrorMessage = "Category Name Min Length Is 3")]
        [MaxLength(20, ErrorMessage = "Category Name Max Length Is 20")]
        [DisplayName("Category Name")]
        public required string Name { get; set; }
        [MinLength(3, ErrorMessage = "Description Min Length Is 3")]
        [MaxLength(250, ErrorMessage = "Description Max Length Is 250")]
        public required string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
