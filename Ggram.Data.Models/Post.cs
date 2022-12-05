using System.ComponentModel.DataAnnotations;

namespace Ggram.Data.Models
{
    public class Post
    {
        public int Id { get; set; }
        //Title, Description, Images
        [MaxLength(20)]
        [Required]
        public string Title { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }
    }
}