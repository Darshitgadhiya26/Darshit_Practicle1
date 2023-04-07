using System.ComponentModel.DataAnnotations;

namespace Darshit_Practicle1.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; } 

        public DateTime ModifiedOn { get; set; } 

        public int? ParentCategoryId { get; set; }

        public virtual Category? ParentCategory { get; set; }

    }
}
