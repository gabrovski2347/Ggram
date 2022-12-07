using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ggram.Data.Models
{
    public class Post : BaseDeletableModel
    {
        public int Id { get; set; }
        //Title, Description, Images
        [MaxLength(20)]
        [Required]
        public string Title { get; set; } = null!;

        [MaxLength(100)]
        public string Description { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        [Required]
        public ApplicationUser ApplicationUser { get; set; }
    }
}