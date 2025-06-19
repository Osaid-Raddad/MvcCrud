using System.ComponentModel.DataAnnotations;

namespace introToMvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string? Name { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string? Description { get; set; }
        [Required]
        [Range(0.01, 100000.00)]
        public decimal Price { get; set; }

        public int? CategoryId {get; set; }
        public Category? Category { get; set; }

    }
}
