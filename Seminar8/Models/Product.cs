using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seminar8.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;

        [Precision(18, 2)]
        public decimal Price { get; set; }
        public int? UnitStock { get; set; }
        [Display(Name = "Category Name")]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public int? UnitInOrder { get; set; }
        public string Image { get; set; } = String.Empty;

        [NotMapped]
        [DataType(DataType.Upload)]
        [Display(Name = "Upload Image")]
        [Required]
        public IFormFile? ImageFile { get; set; }

    }
}
